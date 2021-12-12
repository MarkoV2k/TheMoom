using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCycle : MonoBehaviour
{
    public GameObject wind;
    public int onTime;
    public int offTime;
    public void Start()
    {
        StartCoroutine(cycle());
    }
    IEnumerator cycle()
    {
        yield return new WaitForSecondsRealtime(onTime);
        wind.SetActive(false);
        yield return new WaitForSecondsRealtime(offTime);
        wind.SetActive(true);
        StartCoroutine(cycle());
    }
}
