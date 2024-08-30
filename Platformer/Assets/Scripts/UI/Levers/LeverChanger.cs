using UnityEngine;

public class LeverChanger : MonoBehaviour
{
    [SerializeField] private Lever lever;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            lever.ActivatorChange();
        }
    }
}
