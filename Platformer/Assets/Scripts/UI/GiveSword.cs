using UnityEngine;

public class GiveSword : MonoBehaviour
{
    [SerializeField] private GameObject sword, infoPlate;
    [SerializeField] private AttackScript attackScript;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            attackScript.enabled = true;
            infoPlate.SetActive(true);

            Destroy(sword);            
            Destroy(gameObject);
        }
    }
}
