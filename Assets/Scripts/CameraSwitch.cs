using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camOn;
    public Camera camOff;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            camOn.enabled = true;
        }
        else
        {
            
        };
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            camOff.enabled = false;
        }
        else
        {
            
        };
    }
    

}
