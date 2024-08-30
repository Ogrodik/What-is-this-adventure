using UnityEngine;

public class DamageScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
            Destroy(collision.gameObject);
    }

    public void End()
    {
        Destroy(gameObject);
    }
}
