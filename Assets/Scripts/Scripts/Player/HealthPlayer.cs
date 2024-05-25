using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public float healthcanvas;
    Health Health;
    public int playerDamage = 5;
    public int coin = 100;
    private void Start()
    {
        Health = GetComponent<Health>();
     
    }
    private void Update()
    {
        healthcanvas = Health.currentHealth;
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
}
