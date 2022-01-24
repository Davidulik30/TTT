using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    //List<GameObject> line = new List<GameObject>();
    public GameObject[] line = new GameObject[3];
    public static bool active;
    int p = 0;
    
    void Start()
    {
        active = false;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (active==false&&line[2]!=null)
        {
            
            if (line[0].name == line[1].name&&line[0].name==line[2].name)
            {
                active = true;
                GetComponent<BoxCollider>().enabled = false;
                GetComponent<MeshRenderer>().enabled = true;
                Counting.sign = line[0].name;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!active)
        {
            line[p] = other.gameObject;

            p++;
        }
    }
}
