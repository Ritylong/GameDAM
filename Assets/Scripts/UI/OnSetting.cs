using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnSetting : MonoBehaviour
{
    GameObject setting;
    public void Start()
    {
        setting = GameObject.Find("Setting");


    }
    public void OnSeTTing()
    {
        GameObject[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            if (obj.name == "Setting")
            {
                obj.SetActive(true);
                break;
            }
        }

    }
}
