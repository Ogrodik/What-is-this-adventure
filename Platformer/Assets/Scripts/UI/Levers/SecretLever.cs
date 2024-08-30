using UnityEngine;

public class SecretLever : MonoBehaviour
{
    [SerializeField] Transform secret;
    int secretNum = 6;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (secret != null && secretNum > 0)
            {
                secret.position += new Vector3(0, 1);
                secretNum--;
            }
        }
    }
}
