using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void ZmienScene()
    {
        SceneManager.LoadScene(1);
    }
    public void ZamknijGre()
    {
        Application.Quit();
    }
}
