using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraOpenScreen : MonoBehaviour
{
    CinemachineVirtualCamera screenCamera;
    GameObject player;
    GameObject cameravitual;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        screenCamera = GetComponent<CinemachineVirtualCamera>();
        cameravitual = GameObject.Find("Virtual Camera");
      
    }
   
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            screenCamera.Follow = player.transform;
            cameravitual.GetComponent<BoxCollider2D>().enabled = false;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
      
    }
        
}
