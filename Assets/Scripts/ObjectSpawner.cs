using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public Transform prefab;
    public int czas;
    private void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        Instantiate(prefab, new Vector3(1 * 0, 25f, 0), Quaternion.identity);
        yield return new WaitForSecondsRealtime(czas);
        StartCoroutine(spawn());
    }
}
