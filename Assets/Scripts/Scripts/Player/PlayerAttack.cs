using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;
    HealthPlayer healthPlayer;

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        healthPlayer = FindAnyObjectByType<HealthPlayer>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
        if (Input.GetMouseButton(1) && cooldownTimer > 0.25 && playerMovement.canAttack())
           Skill();

        cooldownTimer += Time.deltaTime;
        HealthSkill();
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;
        fireballs[FindFireball()].transform.position = firePoint.position;
        fireballs[FindFireball()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private void Skill()
    {  
        if(healthPlayer.Mana > 2 )
        {
            anim.SetTrigger("attack");
            cooldownTimer = 0;
            fireballs[FindFireball()].transform.position = firePoint.position;
            fireballs[FindFireball()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
            healthPlayer.Mana = healthPlayer.Mana - 2;
        } else return;
            
        
    }
    private int FindFireball()
    {
        for (int i = 0; i < fireballs.Length; i++)
        {
            if (!fireballs[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
    public void HealthSkill()
    {
        GameObject player = GameObject.Find("Player");
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();

            foreach (GameObject obj in allObjects)
            {
                if (obj.name == "ThongTin")
                {
                    if (obj.GetComponent<ThongTin>().healthSkill > 0)
                    {
                        player.GetComponent<Health>().currentHealth = player.GetComponent<Health>().currentHealth +20f;
                        obj.GetComponent<ThongTin>().healthSkill--;
                    }

                }
            }
           
        }
    }
}