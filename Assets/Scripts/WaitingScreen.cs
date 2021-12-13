using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitingScreen : MonoBehaviour
{
    public int screenTime;
    public int sceneID;
    public void Start()
    {
        StartCoroutine(waitingScreen());
    }
    IEnumerator waitingScreen()
    {
        yield return new WaitForSecondsRealtime(screenTime);
        SceneManager.LoadScene(sceneID);
    }
}
