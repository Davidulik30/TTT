using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class Rotating : MonoBehaviour
{
    public static bool  pressed = false;
    
    public GameObject ToGame;

   

    public void CamRotate()
    {
        pressed = true;
        ToGame.SetActive(false);
    }
}
