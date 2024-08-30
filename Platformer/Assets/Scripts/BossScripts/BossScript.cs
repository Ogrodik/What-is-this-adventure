using UnityEngine;

public class BossScript : MonoBehaviour
{
    private float state;
    BossMover mover;
    BossAttack attack;
    BossSceneScript bossScene;
    BossHpManager hpManager;

    [SerializeField] private GameObject secret;

    private void Awake()
    {
        mover = GetComponent<BossMover>();
        attack = GetComponent<BossAttack>();
        bossScene = GetComponentInChildren<BossSceneScript>();   
        hpManager = GetComponent<BossHpManager>();
    }

    private void FixedUpdate()
    {
        Debug.Log(state);
        StateController();
    }

    private void StateController ()
    {
        if(state != hpManager.state)
        {
            state = hpManager.state;
            attack.state = state;

            if (state == 1)
            {
                mover.speed *= 1.5f;
                bossScene.StartStepTwo();
            }
            if (state == 2)
            {
                bossScene.StartStepThree();
            }
        }        
    }
}
