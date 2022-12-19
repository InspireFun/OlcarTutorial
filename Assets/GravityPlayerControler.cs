using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPlayerControler : MonoBehaviour
{
    public Transform worldPosition;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    private void FixedUpdate()
    {
        Vector3 ground = (worldPosition.position - rb.position).normalized;

        transform.up = ground;

        rb.AddRelativeForce(ground * 10f*rb.mass);
    }
}
