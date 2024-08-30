using UnityEngine;

public class BombScript : MonoBehaviour
{
    [SerializeField] private float timeToBOOM;

    private void FixedUpdate()
    {
        timeToBOOM -= Time.deltaTime;

        if (timeToBOOM < 0)
            Destroy(gameObject);
    }
}
