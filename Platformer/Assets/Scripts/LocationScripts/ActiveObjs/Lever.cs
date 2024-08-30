using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private GameObject end;
    private Vector3[] quaternions = new Vector3 [2];
    private bool activator;

    private void Awake()
    {
        quaternions[0] = new Vector3(0, 0, 200);
        quaternions[1] = new Vector3(0, 0, -200);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
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
            transform.rotation = Quaternion.Euler(quaternions[0]);
        else
            transform.rotation = Quaternion.Euler(quaternions[1]);
    }
}
