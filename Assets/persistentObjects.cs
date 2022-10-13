using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persistentObjects : MonoBehaviour
{
    public persistentObjects instance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
