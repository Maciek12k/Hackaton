using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingPos : MonoBehaviour {
    public GameObject p0, p1, p2;
    public float UpForce;
    Vector3 [] kierunek = new Vector3[3];
    //public LineRenderer lr;


    void Start () {
        //kierunek = transform.rotation * Vector3.forward;
        //lr.positionCount = 3;
        kierunek[0] = Vector3.zero;
	}
	
	void Update () {
        kierunek[1] = transform.rotation * Vector3.forward;
        kierunek[1] *= UpForce;
        kierunek[2] = new Vector3(kierunek[1].x*2, 0, kierunek[1].z*2);
        //lr.SetPositions(kierunek);
        p0.transform.position = kierunek[0];
        p1.transform.position = kierunek[1];
        p2.transform.position = kierunek[2];

    }
}
