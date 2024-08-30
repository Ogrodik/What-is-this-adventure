using UnityEngine;

public class LeverBoss : MonoBehaviour
{
    [SerializeField] private GameObject lever;
    [SerializeField] private BossHpManager boss;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            boss.Damage(10);

            Destroy(lever);
            Destroy(gameObject);
        }
    }
}
