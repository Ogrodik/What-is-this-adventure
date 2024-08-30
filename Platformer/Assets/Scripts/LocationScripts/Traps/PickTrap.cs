using UnityEngine;

public class PickTrap : MonoBehaviour
{
    [SerializeField] private Transform[] picks;
    private Animator animator;
    private bool on;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnOrOFF ()
    {
        on = !on;
        animator.SetBool("Active", on);
    }
}
