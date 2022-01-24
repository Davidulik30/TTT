using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public static bool pressedBack=false;

    public GameObject start;
    public GameObject result;
    public GameObject back;
    public GameObject text;
   
    public void GoBack()
    {
        pressedBack = true;
        start.SetActive(false);
        result.SetActive(false);
        back.SetActive(false);
        text.SetActive(false);
    }
}
