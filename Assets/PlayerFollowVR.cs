using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowVR : MonoBehaviour
    
{
    public Transform tf;
    public float strength;

    void Update()
    {
        transform.rotation = tf.rotation;
        transform.position = tf.position + tf.forward*strength;
    }
}
