using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    HealthPlayer healthPlayer;
 [SerializeField] GameObject chest1;
    private void Start()
    {
        healthPlayer = FindAnyObjectByType<HealthPlayer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.tag == "Player")
        {
          chest1.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            chest1.SetActive(false);
        }

    }
   public void ChestOpen()
    {
        
            Destroy(chest1);
            Destroy(this.gameObject);
             healthPlayer.Coin = healthPlayer.Coin + 30;
    }
}
