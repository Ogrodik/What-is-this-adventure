using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public int jumpForce;

    private Rigidbody2D rb;
    private Animator animator;
    private bool groundConnect = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if (groundConnect)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            animator.SetBool("Jump", true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            groundConnect = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            groundConnect = true;
            animator.SetBool("Jump", false);
        }
    }
}
