using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlaneControl : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float forwardForce;

    [SerializeField]
    private float rotateTorque;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * forwardForce, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(transform.right * rotateTorque, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-transform.right * rotateTorque, ForceMode.VelocityChange);
        }
    }
}
