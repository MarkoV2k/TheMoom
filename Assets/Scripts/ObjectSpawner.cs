using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public Transform prefab;
    public int czasPomiedzy;
    public int iloscPowtorzen;
    public int czasOff;
    private void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        for(int i=0; i<iloscPowtorzen; i++)
        {
            Instantiate(prefab, new Vector3(1 * 0, 25f, 0), Quaternion.identity);
            yield return new WaitForSecondsRealtime(czasPomiedzy);
        }
        yield return new WaitForSecondsRealtime(czasOff);
        StartCoroutine(spawn());
    }
}
