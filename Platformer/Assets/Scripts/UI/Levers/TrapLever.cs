using UnityEngine;

public class TrapLever : MonoBehaviour
{
    [SerializeField] private PickTrap trap;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            trap.OnOrOFF();
        }
    }
}
