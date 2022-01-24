using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculating : MonoBehaviour
{
    public string  sign;
    public int fillingnumber;
    void Start()
    {
        sign = "none";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        sign = collision.gameObject.name;
        
    }
}
