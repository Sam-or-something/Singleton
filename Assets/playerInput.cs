using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    [SerializeField] score scoreScript;
    [SerializeField] sceneChanger sceneChangerScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreScript.AddPoints(10);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            sceneChangerScript.ChangeSceneSequentially();
        }
    }
}
