using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacja : MonoBehaviour
    
{
    public Transform tf;
    public Transform Kostka;

    public Transform kostkaStatic;
    //private Vector3 globalPos;
    // private Vector3 globalPosParent;


    void Update()
    {
        Vector3 angle = tf.transform.rotation.eulerAngles;
        angle = new Vector3(-angle.z, angle.y, angle.x);

        transform.localRotation = Quaternion.Euler(angle);
        //Vector3 temp = Kostka.position - tf.position;
        //transform.localPosition = temp;
        Vector3 temp = Kostka.position - kostkaStatic.position;
        transform.localPosition = new Vector3(-temp.z, temp.y, temp.x);


    }
}
