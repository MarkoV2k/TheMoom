using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camOff;
    public Camera camOn;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void OnTriggerEnter2D(Collider2D collision)
    {
        camOff.enabled = false;
        camOn.enabled = true;
    }

}
