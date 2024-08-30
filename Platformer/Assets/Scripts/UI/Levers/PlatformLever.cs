using UnityEngine;

public class PlatformLever : MonoBehaviour
{
    [SerializeField] private BigPlatformController platformController;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            platformController.ReChange();
        }
    }
}
