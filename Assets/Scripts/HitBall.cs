using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBall : MonoBehaviour
{
    public GameObject kula;//objekt niszczony

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "player")
        {//sprawdzenie ,czy w kolizji jest gracz

            Destroy(gameObject);//zniszczenie objektu, z ktorym jestes w kolizji

            Destroy(kula);//zniszczenie objektu

        }
        else
        {

        }

    }
}
