using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    GameObject player; Health Health;
    private void Update()
    {
        if (!FindAnyObjectByType<UIControl>().playerDead)
        {
            player = GameObject.Find("Player");
            Health = player.GetComponent<Health>();
        }
        else
        {
            return;
        }
        InFire();

    }
    private float timefire = 0f;
    private const float damageInterval = 2f;
    private const float damageAmount = 20f;
    private bool isInDamageZone = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInDamageZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInDamageZone = false;
            timefire = 0f;
        }
    }

    private void InFire()
    {
        if (isInDamageZone)
        {
            timefire += Time.deltaTime;

            if (timefire >= damageInterval)
            {
                Health.TakeDamage(damageAmount);
                timefire = 0f;
            }
        }
    }
}
