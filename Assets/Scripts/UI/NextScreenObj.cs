using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScreenObj : MonoBehaviour
{
    ScreenControl screenControl;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(DelayNext(1f));
        }
      
    }
    IEnumerator DelayNext(float delay)
    {
        yield return new WaitForSeconds(delay);
        Callnext();
    }
    private void Callnext()
    {
        screenControl.LoadGame();
    }
      
   
    void Start()
    {
        screenControl = GetComponent<ScreenControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
