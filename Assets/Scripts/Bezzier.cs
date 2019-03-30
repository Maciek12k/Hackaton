using UnityEngine;

public class Bezzier : MonoBehaviour {

    private int numPoints = 200;
    private Vector3[] points = new Vector3[200];
    public LineRenderer lineRenderer;

    public float dystans = 4f;
    public float GroundAngle = 5f;
    bool onGround = false;
    private Vector3 lastPoint = new Vector3();

    public Transform Point0, Point1, Point2, Player, Camera;
	
	void Start () {
        lineRenderer.positionCount = numPoints;
        DrawQuadraticBezzierLine();
	}

    private void Update()
    {
        checkTeleportation();
    }
    void FixedUpdate () {
        DrawQuadraticBezzierLine();
    }

    void checkTeleportation()
    {
        if(onGround & Input.GetKeyDown(KeyCode.Mouse0))
        {
            Player.position = lastPoint;
        }
    }


    Vector3 getQuadraticBezzierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        float u = 1 - t;
        return (u * (u * p0 + t * p1) + t * (u * p1 + t * p2));
    }
    private void DrawQuadraticBezzierLine()
    {

        RaycastHit hit;
        bool isColliding = false;
        float acc = 1 / (float)numPoints;
        float time = acc;
        for (int i = 0; i<numPoints; i++)
        {
            if (!isColliding)
            {
                points[i] = getQuadraticBezzierPoint(time, Point0.position, Point1.position, Point2.position);
                lastPoint = points[i];
                time += acc;

                if (i > 0)
                {
                    float angle = 0f;
                    Vector3 deltaPos = points[i] - points[i - 1];
                    Ray ray = new Ray(points[i - 1], deltaPos);
                    if (Physics.Raycast(ray, out hit, dystans))
                    {
                        if (hit.collider.tag == "Enviroment")
                        {
                            isColliding = true;
                            //Debug.DrawRay(ray.origin, ray.direction, Color.gray);
                            angle = Vector3.Angle(Vector3.up, hit.normal);
                        }
                        
                        if(angle < GroundAngle)
                        {
                            //Debug.Log("Blisko do góry");
                            lineRenderer.startColor = Color.green;
                            lineRenderer.endColor = Color.green;
                            onGround = true;
                        } else
                        {
                            lineRenderer.startColor = Color.red;
                            lineRenderer.endColor = Color.red;
                            onGround = false;
                        }

                    }

                }
            }
            else
            {
                points[i] = lastPoint;
            }
        }
        lineRenderer.SetPositions(points);
    }
}
