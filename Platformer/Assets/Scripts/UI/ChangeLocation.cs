using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLocation : MonoBehaviour
{
    [SerializeField] private GameObject go;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            go.SetActive(true);
        }
    }
}
