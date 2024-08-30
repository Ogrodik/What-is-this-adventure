using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [SerializeField] private GameObject box, bomb;
    [Space, SerializeField] private float attackSpeed;
    [HideInInspector] public float state;
    float timeToAttack;

    private void FixedUpdate()
    {
        AttackController();
    }

    void AttackController()
    {
        if(state == 0)
        {
            Attack(box);
        }
        else if(state == 1) 
        {
            Attack(bomb);
        }
    }

    private void Attack(GameObject obj)
    {
        timeToAttack -= Time.deltaTime;
        if (timeToAttack < 0)
        {
            timeToAttack = attackSpeed;
            Instantiate(obj, new Vector2(transform.position.x, transform.position.y - 8), Quaternion.identity);
        }
    }
}
