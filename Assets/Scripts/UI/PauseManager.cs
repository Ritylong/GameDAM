using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
   
        public static PauseManager instance;

        void Awake()
    {
        this.gameObject.SetActive(false);
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
