using UnityEngine;

public class InputScript : MonoBehaviour
{
    private JumpScript jumpScript;
    private AttackScript attackScript;
    private Animator animator;
    private SpriteRenderer sprite;

    private float rot = 1;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        jumpScript = GetComponent<JumpScript>();
        attackScript = GetComponent<AttackScript>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        MoveController();
        JumpController();
        AttackController();        
    }

    void MoveController()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("Run", true);

            if (Input.GetAxis("Horizontal") > 0)
            {
                sprite.flipX = false;
                rot = 1;
            }
            else
            {
                sprite.flipX = true;
                rot = -1;
            }
        }
        else
            animator.SetBool("Run", false);
    }

    void JumpController()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpScript.Jump();
        }
    }

    void AttackController ()
    {
        if (attackScript != null && Input.GetButtonDown("Fire1"))
        {
            attackScript.Attack(rot);
        }
    }
}
