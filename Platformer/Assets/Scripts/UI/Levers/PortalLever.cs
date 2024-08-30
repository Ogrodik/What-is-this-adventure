using UnityEngine;

public class PortalLever : MonoBehaviour
{
    [SerializeField] private Portal portalActive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {            
            portalActive.ActivatorChange();
        }
    }
}
