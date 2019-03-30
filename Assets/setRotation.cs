using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setRotation : MonoBehaviour
{
    public Transform tf;

    void Update()
    {
        Vector3 temp = tf.transform.rotation.eulerAngles;
        temp = new Vector3(temp.z, temp.y, temp.x);
        transform.rotation = Quaternion.Euler(tf.rotation.z, tf.rotation.y, tf.rotation.x);
    }
}
