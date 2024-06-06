using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int health ;
    public GameObject deathEffect;
    public bool isInvulnerable = false;
    public string nextSceneName;
   [SerializeField] GameObject finish;

  

    public void TakeDamage(int damage)
    {
        if (isInvulnerable)
            return;

        health -= damage;

        if (health <= 150)
        {
            GetComponent<Animator>().SetBool("IsEnraged", true);
        }

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);

        //GameManager.instance.ChangeSceneAfterDelay(3f, nextSceneName);
        finish.SetActive(true);

        Destroy(gameObject);
    }

    public bool IsDefeated()
    {
        return health <= 0;
    }
}
