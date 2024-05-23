using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] bool destroyOnScreen = true;
    void Start()
    {
      if (!destroyOnScreen)
        {
            DontDestroyOnLoad(this);
        }
        else
        {
            return;
        }
        
    }
}
