using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    private bool isMoving;
    public float gravityMultiplier;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        isMoving = false;
    }

    private void FixedUpdate()
    {

        Debug.Log(isMoving);
      

        if (Input.GetKeyUp(KeyCode.Z))
        {
            isMoving = false;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            isMoving = false;
        }


        Move();
        Turn();
        Fall();    


    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            rb.AddRelativeForce(new Vector3( Vector3.forward.x,0,Vector3.forward.z) * speed * 10);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(-(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * 10) / 2);
            isMoving = true;
        }
        Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
        localVelocity.x = 0;
        rb.velocity = transform.TransformDirection(localVelocity);
    }

    private void Turn()
    {
        if (Input.GetKey(KeyCode.D) && isMoving)
        {
            rb.AddTorque(Vector3.up * turnSpeed * 10);
        }

        if (Input.GetKey(KeyCode.Q) && isMoving)
        {
            rb.AddTorque(-Vector3.up * turnSpeed * 10);
        }
    }

    private void Fall()
    {
        rb.AddForce(Vector3.down * gravityMultiplier * 10);
    }

}
