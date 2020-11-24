using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float m_horizontalInput;
    private float m_verticalInput;
    private float m_steeringAngle;

    public WheelCollider front_R_Wheel, front_L_Wheel;
    public WheelCollider rear_R_Wheel, rear_L_Wheel;
    public Transform front_R_Transform, front_L_Transform;
    public Transform rear_R_Transform, rear_L_Transform;
    public float maxSteerAngle = 30;
    public float motorForce = 50;
    public float brakeForce = 5000;


    public void GetInput()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetAxis("Vertical");
       
    }

    private void Steer()
    {
        m_steeringAngle = maxSteerAngle * m_horizontalInput;
        front_L_Wheel.steerAngle = m_steeringAngle;
        front_R_Wheel.steerAngle = m_steeringAngle;
    }

    private void Acceleration()
    {
        front_L_Wheel.motorTorque = m_verticalInput * motorForce;
        front_R_Wheel.motorTorque = m_verticalInput * motorForce;
        rear_L_Wheel.motorTorque = m_verticalInput * motorForce;
        rear_R_Wheel.motorTorque = m_verticalInput * motorForce;
    }

    private void BrakeOn()
    {
        front_L_Wheel.brakeTorque = brakeForce;
        front_R_Wheel.brakeTorque = brakeForce;
        rear_L_Wheel.brakeTorque = brakeForce;
        rear_R_Wheel.brakeTorque = brakeForce;
    }

    private void BrakeOff()
    {
        front_L_Wheel.brakeTorque = 0;
        front_R_Wheel.brakeTorque = 0;
        rear_L_Wheel.brakeTorque = 0;
        rear_R_Wheel.brakeTorque = 0;
    }
    private void UpdateWheelPoses()
    {
        UpdateWheelPose(front_L_Wheel, front_L_Transform);
        UpdateWheelPose(front_R_Wheel, front_R_Transform);
        UpdateWheelPose(rear_L_Wheel, rear_L_Transform);
        UpdateWheelPose(rear_R_Wheel, rear_R_Transform);
    }
    private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion _quat = _transform.rotation;

        _collider.GetWorldPose(out _pos, out _quat);

        _transform.position = _pos;
        _transform.rotation = _quat;
    }

    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Acceleration();
        UpdateWheelPoses();
        if (Input.GetButtonDown("Jump"))
        {
            BrakeOn();
        }

        if (Input.GetButtonUp("Jump"))
        {
            BrakeOff();
        }
    }

}
