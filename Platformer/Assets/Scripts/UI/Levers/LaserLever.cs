using System.Net.Sockets;
using UnityEngine;

public class LaserLever : MonoBehaviour
{
    [SerializeField] private LaserControll[] laser;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < laser.Length; i++)
                laser[i].ChangeLaser();
        }
    }
}
