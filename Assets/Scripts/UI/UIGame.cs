using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGame : MonoBehaviour
{

    public static UIGame instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
}
