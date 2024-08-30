using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private GameObject end;    
    [SerializeField] private bool activator;
    private SpriteRenderer magicSymbol;

    private void Awake()
    {
        magicSymbol = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && activator)
            end.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            end.SetActive(false);
    }

    public void ActivatorChange()
    {
        activator = !activator;

        if (activator)
            magicSymbol.color = Color.cyan;
        else
            magicSymbol.color = Color.black;        
    }
}
