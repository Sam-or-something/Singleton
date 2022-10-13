using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    [SerializeField] string[] sceneNames;
    [SerializeField] int sceneIndex;

    public void ChangeSceneSequentially()
    {
        if(sceneIndex >= sceneNames.Length)
        {
            sceneIndex = 0;
        }
        ChangeSceneAndIncrementIndex();
    }

    void ChangeSceneAndIncrementIndex()
    {
        SceneManager.LoadScene(sceneNames[sceneIndex]);
        sceneIndex++;
    }
}
