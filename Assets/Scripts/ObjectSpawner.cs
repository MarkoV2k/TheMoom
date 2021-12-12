using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public Transform prefab;
    private void Start()
    {
        for(int i=0; i<3; i++)
        {
            Instantiate(prefab, new Vector3(i * 0, 25f, 0), Quaternion.identity);
        }
    }
}
