using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField, Range(0f, 1f)] private float strength;
    Vector3 prevPos, delta;

    private void Start()
    {
        prevPos = target.position;
    }

    private void FixedUpdate()
    {
        delta = target.position - prevPos;
        prevPos = target.position;

        transform.position += delta * strength;
    }
}
