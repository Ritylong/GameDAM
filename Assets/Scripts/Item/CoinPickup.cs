using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    // Start is called before the first frame update
    HealthPlayer healthPlayer;
    void Start()
    {
        healthPlayer = FindAnyObjectByType<HealthPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            healthPlayer.Coin = healthPlayer.Coin + 1;
            Destroy(this.gameObject);
        }
        
    }
}
