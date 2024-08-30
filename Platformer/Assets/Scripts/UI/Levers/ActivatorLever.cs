using UnityEngine;

public class ActivatorLever : MonoBehaviour
{
    [SerializeField] private GameObject obj;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            obj.SetActive(!obj.activeSelf);
        }
    }
}
