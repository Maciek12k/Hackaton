using UnityEngine;

public class deleter : MonoBehaviour
{
    public GameObject kaktus;
    void Start()
    {
        Destroy(gameObject, 0.6f);
    }
    ~deleter()
    {
        Instantiate(kaktus, transform.position, Quaternion.identity);
    }
}
