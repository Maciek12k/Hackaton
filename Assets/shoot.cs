using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public Transform jeden, dwa, tf;
    //public Camera cam;

    void Update()
    {
        //Vector3 temp = dwa.position - jeden.position;
        //Debug.DrawRay(tf.position, tf.forward, Color.blue, 200f);
        if (Input.GetKeyDown("s"))
        {
            //sGetComponent<Animator>().ResetTrigger("fire");
            GetComponent<Animator>().SetTrigger("fire");

            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, 400f))
            {
                //Debug.Log(hit.transform.tag);
                if(hit.transform.tag=="kaktus")
                {
                    //Debug.Log("Trafiles kaktusa");
                    Target target = hit.transform.GetComponent<Target>();
                    if(target!=null)
                    {
                        target.Die();
                        //Debug.Log("Zginal");
                    }

                }
            }
            
            //Debug.Log("dziala");
            
        }
    }
}
