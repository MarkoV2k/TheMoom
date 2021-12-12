using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject Sphere;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            FindObjectOfType<PointsManager>().DodajPunkt();
            Destroy(gameObject);
        }
        else
        {
            
        }
        
    }
}
