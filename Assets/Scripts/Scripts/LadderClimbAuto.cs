using UnityEngine;

public class LadderClimbAuto2D : MonoBehaviour
{
    public float climbSpeed = 3.0f;
    private bool isClimbing = false;
    private Rigidbody2D rb2d;
    private Collider2D ladderCollider;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 1; // Ensure gravity is enabled initially
    }

    void Update()
    {
        if (isClimbing)
        {
            float vertical = Input.GetAxis("Vertical");
            rb2d.velocity = new Vector2(rb2d.velocity.x, vertical * climbSpeed);
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            isClimbing = true;
            rb2d.gravityScale = 0; // Disable gravity while climbing
            rb2d.velocity = Vector2.zero; // Reset velocity
            
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            isClimbing = false;
            rb2d.gravityScale = 1; // Restore gravity when not climbing
        }
    }
}

