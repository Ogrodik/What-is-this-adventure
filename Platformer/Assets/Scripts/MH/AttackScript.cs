using UnityEngine;

public class AttackScript : MonoBehaviour
{    
    [SerializeField] private float attackSpeed;

    [SerializeField] private GameObject AttackObj;

    Animator animator;
    float rotation, time = 0;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        time -= Time.fixedDeltaTime;
    }

    public void Attack (float rot)
    {
        if(time<0)
        {
            rotation = rot;
            animator.SetBool("Attack", true);
            time = attackSpeed;
        }  
    }

    public void End ()
    {
        animator.SetBool("Attack", false);
    }

    public void GoAttack ()
    {
        Instantiate(AttackObj, new Vector3(transform.position.x + rotation, transform.position.y), Quaternion.identity, transform);
    }
}
