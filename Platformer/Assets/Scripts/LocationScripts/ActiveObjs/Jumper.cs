using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private float force;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            collision.rigidbody.velocity = new Vector2(collision.rigidbody.velocity.x, force);
    }
}
