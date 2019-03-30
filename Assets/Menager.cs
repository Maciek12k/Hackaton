using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menager : MonoBehaviour
{
    public float time = 5;
    public float kaktus_offset = 0.2f;
    public GameObject kaktus;
    public GameObject bum;
    public Transform [] spawnPoint = new Transform [10];
    public bool[] isAvailable = new bool[10];
    public int kaktusN = 0;
    public int maxKaktusy = 3;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<10; i++)
        {
            isAvailable[i] = true;
        }
    }

    void Update()
    {
        if (kaktusN <maxKaktusy) {
            int rand;
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = Random.Range(5f, 10f);
                do
                {
                    rand = (int)Random.Range(0, 10);


                } while (!isAvailable[rand]);
                Vector3 temp = spawnPoint[rand].position;
            
                Instantiate(bum, spawnPoint[rand].position, Quaternion.identity);
                Instantiate(kaktus, temp, Quaternion.identity);
                isAvailable[rand] = false;
                kaktusN++;
            }

        }
    }
}
