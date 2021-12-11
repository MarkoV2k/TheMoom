using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    public int Level;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(Level);
    }
}
