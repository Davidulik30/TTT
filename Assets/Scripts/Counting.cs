using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counting : MonoBehaviour
{
    public GameObject text;
    public static string sign;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Calculating()
    {
        GameObject[] spawnpoints;
        spawnpoints  = GameObject.FindGameObjectsWithTag("plate");

        if (sign == "Cross(Clone)")
        {
            text.GetComponent<Text>().text = "X" + " WINS!!";
        }
        else
        {
            if (sign == "Zeros(Clone)")
            {
                text.GetComponent<Text>().text = "O" + " WINS!!";
            }
            else
            {
                text.GetComponent<Text>().text = "NO" + " WINNER";
            }
        }
            
    }
}
