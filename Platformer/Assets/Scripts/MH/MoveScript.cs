using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField] private int speed;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        }        
    }    
}
