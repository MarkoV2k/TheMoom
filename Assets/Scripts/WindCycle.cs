using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCycle : MonoBehaviour
{
    public GameObject toCycle;
    public int onTime;
    public int offTime;
    public void Start()
    {
        StartCoroutine(cycle());
    }
    IEnumerator cycle()
    {
        yield return new WaitForSecondsRealtime(onTime);
        toCycle.SetActive(false);
        yield return new WaitForSecondsRealtime(offTime);
        toCycle.SetActive(true);
        StartCoroutine(cycle());
    }
}
