using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
    private bool hit;
    private float lifetime;
  
    
    HealthPlayer healthPlayer;

    private Animator anim;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        healthPlayer = FindAnyObjectByType<HealthPlayer>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (hit) return;
        float movementSpeed = speed * Time.deltaTime * direction;
        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if (lifetime > 3) gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
        boxCollider.enabled = false;
        anim.SetTrigger("explode");

        if (collision.tag == "Enemy")
        {
            try
            {
                collision.GetComponent<Health>().TakeDamage(healthPlayer.playerDamage);
            }
            catch (Exception e)
            {
                Debug.LogError("Error: " + e.Message);
            }
        }

        if (collision.tag == "Boss")
        {
            collision.GetComponent<BossHealth>().TakeDamage(healthPlayer.playerDamage);
        }
          

    }
    public void SetDirection(float _direction)
    {
        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}