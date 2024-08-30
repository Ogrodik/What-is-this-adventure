using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float liveTime;

    void FixedUpdate()
    {
        liveTime -= Time.deltaTime;

        if(liveTime < 0 )
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
            
    }
}
