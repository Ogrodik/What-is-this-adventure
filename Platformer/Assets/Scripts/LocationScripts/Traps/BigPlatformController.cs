using UnityEngine;

public class BigPlatformController : MonoBehaviour
{
    [SerializeField] private int moveMod, speed;
    [SerializeField] private Vector3[] endPos;
    private JointMotor2D motor;

    private SliderJoint2D slider;

    private void Awake()
    {
        slider = GetComponent<SliderJoint2D>();
    }

    private void FixedUpdate()
    {
        Mover();
    }

    public void ReChange()
    {
        if (speed == 0)
            speed = 2 * moveMod;
        else
            speed = 0;

        GiveMotor();
    }

    private void Mover ()
    {
        if (transform.position.x >= endPos[1].x || transform.position.x <= endPos[0].x)
        {
            moveMod *= -1;
            speed *= -1;
        }
        
        GiveMotor();
    }

    private void GiveMotor()
    {
        motor = slider.motor;
        motor.motorSpeed = speed;
        slider.motor = motor;
    }


}
