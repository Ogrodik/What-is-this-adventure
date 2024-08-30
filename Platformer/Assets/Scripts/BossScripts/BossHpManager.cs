using UnityEngine;
using UnityEngine.UI;

public class BossHpManager : MonoBehaviour
{
    [SerializeField] private float maxHp;
    private float hp;
    [HideInInspector] public int state;
    [Space, SerializeField] private Image hpLine;
    

    private void Awake()
    {
        hp = maxHp;
    }
    void CheckHp()
    {
        if(hp == 20)
        {
            state = 1;
        }
        else if( hp == 0)
        {
            state = 2;
        }
    }

    public void Damage(int hpDamage)
    {
        hp -= hpDamage;
        hpLine.fillAmount = hp / maxHp;
        CheckHp();
    }
}
