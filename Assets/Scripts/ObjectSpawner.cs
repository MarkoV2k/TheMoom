using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public Transform prefab;
    public int liczbaObiektow;
    private void Start()
    {
        for(int i=0; i<liczbaObiektow; i++)
        {
            Instantiate(prefab, new Vector3(i * 0, 25f, 0), Quaternion.identity);
        }
    }
}
