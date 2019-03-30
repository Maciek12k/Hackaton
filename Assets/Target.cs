using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject obj;

    public void Die()
    {
        Instantiate(obj, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
