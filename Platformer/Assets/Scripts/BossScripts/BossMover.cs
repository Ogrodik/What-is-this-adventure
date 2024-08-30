using UnityEngine;

public class BossMover : MonoBehaviour
{
    public float speed;
    [SerializeField] private Vector3[] targetPoses;
    private int currentVector;

    private void FixedUpdate()
    {
        BossMove();
    }

    private void BossMove()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPoses[currentVector], Time.deltaTime * speed);

        if (transform.position.x >= targetPoses[1].x)
            currentVector = 0;
        else if (transform.position.x <= targetPoses[0].x)
            currentVector = 1;
    }
}
