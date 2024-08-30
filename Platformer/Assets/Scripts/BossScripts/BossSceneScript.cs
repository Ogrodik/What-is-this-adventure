using Unity.VisualScripting;
using UnityEngine;

public class BossSceneScript : MonoBehaviour
{
    [SerializeField] private Transform[] islands, smallIslands, enemy;
    [SerializeField] private Vector3[] islandPoses, smallIslandPoses, enemyPoses;
    [Space, SerializeField] GameObject secret;

    private bool bigIslandsMove = false, smallIslandsMove = false;
    
    public void StartStepTwo ()
    {
        bigIslandsMove = true;
    }

    public void StartStepThree()
    {
        smallIslandsMove = true;
        secret.SetActive(true);
        for (int i = 0;i< enemy.Length; i++)
            enemy[i].position = enemyPoses[i];
    }

    private void FixedUpdate()
    {
        BigIslandMove();
        SmallIslandsMove();
        CheckIslandPositions();
    }

    private void BigIslandMove()
    {
        if (bigIslandsMove)
        {
            for (int i = 0; i < islands.Length; i++)
            {
                islands[i].position = Vector2.MoveTowards(islands[i].position, islandPoses[i], Time.fixedDeltaTime * 2);
            }                
        }
    }

    private void SmallIslandsMove()
    {
        if (smallIslandsMove)
        {
            for (int i = 0; i < smallIslands.Length; i++)
            {
                smallIslands[i].position = Vector2.MoveTowards(smallIslands[i].position, smallIslandPoses[i], Time.fixedDeltaTime * 2);
            }
                
        }
    }

    private void CheckIslandPositions ()
    {
        if (islands[0].position == islandPoses[0])
        {
            bigIslandsMove = false;
        }

        if (smallIslands[0].position == smallIslandPoses[0])
        {
            Destroy(gameObject);
        }            
    }
}
