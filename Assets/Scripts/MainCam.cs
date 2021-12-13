using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour
{
    public Camera camOn;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            camOn.enabled = true;
        }
    }
}
