using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MainController : MonoBehaviour
{
    public GameObject ToGame;
    public GameObject start;
    public GameObject result;
    public GameObject back;
    public CinemachineVirtualCamera cam;
    private CinemachineTrackedDolly dolly;
    void Start()
    {
        dolly = cam.GetCinemachineComponent<CinemachineTrackedDolly>();
    }
    void Update()
    {
        if (Rotating.pressed && dolly.m_PathPosition < 2.02f)
        {
            dolly.m_PathPosition += 0.01f;
            
        }
        else
        {
            if(Back.pressedBack && dolly.m_PathPosition > 0)
            {
                dolly.m_PathPosition -= 0.01f;
                
            }
        }
        if (dolly.m_PathPosition > 2.02f&& Rotating.pressed==true)
        {
           
            start.SetActive(true);
            result.SetActive(true);
            back.SetActive(true);
            Rotating.pressed = false;
        }
        else
        {
            if (dolly.m_PathPosition< 0.01f&& Back.pressedBack==true)
            {
                
                Back.pressedBack = false;
                ToGame.SetActive(true);
            }
        }
    }   
}
