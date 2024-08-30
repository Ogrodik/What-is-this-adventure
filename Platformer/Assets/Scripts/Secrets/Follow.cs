using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform following;

    void FixedUpdate ()
    {
        if(transform.position != following.position && following != null)
        {
            transform.position = following.position;
        }
    }
}
