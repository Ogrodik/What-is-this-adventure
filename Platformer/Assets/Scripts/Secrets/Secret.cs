using UnityEngine;
using UnityEngine.SceneManagement;

public class Secret : MonoBehaviour
{
    [SerializeField] private GameObject secretImage;
    private SaveScript save;
    private Animator animator;

    private void Awake()
    {
        save = GetComponent<SaveScript>();
        animator = GetComponent<Animator>();
        CheckSecret();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            StartAnimate();
    }

    private void StartAnimate ()
    {
        Destroy(gameObject.GetComponent<Collider2D>());
        animator.SetBool("Go", true);
        save.LoadStat("secret"+SceneManager.GetActiveScene().buildIndex);
    }

    void CheckSecret()
    {
        if(save.LoadStat("secret" + SceneManager.GetActiveScene().buildIndex))
        {
            Death();
        }
    }

    public void Death ()
    {
        if(secretImage == null)
        {
            Debug.LogError("NoSecretImage!");
        }
        else
        {
            secretImage.SetActive(true);    
        }
        Destroy(gameObject);
    }
}
