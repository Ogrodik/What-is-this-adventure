using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    [SerializeField] private GameObject boss, endGamePlate;
    [SerializeField] private MoveScript move;
    private Animator animator;
    private bool end = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (boss == null && !end)
            StartEnd();
    }

    private void StartEnd()
    {
        end = false;
        Destroy(move);
        animator.SetBool("End", true);
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void  ActivateEndPlate ()
    {
        Time.timeScale = 0;
        endGamePlate.SetActive(true);
    }
}
