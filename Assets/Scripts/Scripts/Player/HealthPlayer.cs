using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    GameObject player; 
    public float health;
    Health Health;
    public int playerDamage = 5;
    [SerializeField] private int coin;
    private void Start()
    {
     

    }

    private void Update()
    {
        if (!FindAnyObjectByType<UIControl>().playerDead)
        {
            player = GameObject.Find("Player");
            Health = player.GetComponent<Health>();
            this.health = Health.currentHealth;
        } else
        {
            return;
        }
       
    }
   [SerializeField] private int mana = 100;
    public int Mana
    {
        get
        {
            return mana;
        }
        set
        {
            mana = value;
        }
    } 
    public int Coin
    {
        get { return coin;}
        set { coin = value; }
    }
}
