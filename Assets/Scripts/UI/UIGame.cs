using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGame : MonoBehaviour
{
    // Singleton instance
    public static UIGame instance;

    void Awake()
    {
        // Check if another instance already exists
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // Destroy the new instance
        }
        else
        {
            instance = this; // Set the instance to this object
            DontDestroyOnLoad(gameObject); // Don't destroy this object on scene load
        }
    }

    void OnEnable()
    {
        // Subscribe to the sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // Unsubscribe from the sceneLoaded event
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check if the loaded scene is "Credits"
        if (scene.name == "Credit")
        {
            Destroy(gameObject); // Destroy this object if the scene is "Credits"
        }
    }
}
