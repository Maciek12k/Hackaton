using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samePosAsPlayer : MonoBehaviour
{
    public Transform tf;


    // Update is called once per frame
    void Update()
    {
        transform.position = tf.position;
    }
}
