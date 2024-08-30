using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float rotation;
    [Space, SerializeField] private GameObject bullet;
    private GameObject newBullet;

    public void Fire()
    {
        newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(15*rotation, 0), ForceMode2D.Impulse);
    }
}
