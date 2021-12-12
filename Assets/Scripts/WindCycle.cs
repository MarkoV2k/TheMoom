using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCycle : MonoBehaviour
{
    public GameObject wind;
    public void Start()
    {
        StartCoroutine(cycle());
    }
    IEnumerator cycle()
    {
        yield return new WaitForSecondsRealtime(3);
        wind.SetActive(false);
        yield return new WaitForSecondsRealtime(3);
        wind.SetActive(true);
        StartCoroutine(cycle());
    }
}
