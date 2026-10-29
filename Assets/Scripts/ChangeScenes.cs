using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Control : MonoBehaviour
{
    public string sceneName = string.Empty;
    public float delay = 0.2f;

    public void NextScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void StartDelay()
    {
        StartCoroutine(NextSceneWithDelay(delay));
    }

    IEnumerator NextSceneWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }

}