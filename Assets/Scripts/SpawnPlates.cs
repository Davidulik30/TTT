using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlates : MonoBehaviour
{
    public GameObject plateSample;
    public GameObject SpawnSign;
    void Start()
    {
        for (int i = 9; i > 0; i-=3)
        {
            for (int j = 9; j > 0; j-=3)
            {
                var clone2 = Instantiate(SpawnSign, new Vector3(transform.position.x - i, 12, transform.position.z - j), Quaternion.identity);
                clone2.name = "SPAWNER"+i / 3 + " " + j / 3;

                var clone = Instantiate(plateSample, new Vector3(transform.position.x-i, -1.4f, transform.position.z-j),Quaternion.identity);
                clone.name = i / 3 +" "+ j / 3;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
