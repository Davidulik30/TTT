using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSigns : MonoBehaviour
{
    public GameObject cross;
    public GameObject zeros;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnSign(int i)
    {
        if (i%2==0){
            Instantiate(zeros, new Vector3(transform.position.x-1, 12+(2*i), transform.position.z-1), Quaternion.identity);
        }
        else
        {
            Instantiate(cross, new Vector3(transform.position.x-0.25f, 12+(2*i), transform.position.z-0.25f), Quaternion.identity);
        }
    }
}
