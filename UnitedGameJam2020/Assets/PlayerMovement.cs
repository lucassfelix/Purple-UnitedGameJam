using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to the rigidbody component called rb
    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewyasForce = 500f;
    public float gravity = 100f;  

    // Update is called once per frame
    void FixedUpdate()
    {
    
        rb.AddForce(0 , 0, fowardForce * Time.deltaTime); // add an foward force
        rb.AddForce (0, -gravity * Time.deltaTime, 0); // add gravity
        if (Input.GetKey("d"))  // going right
        {
            rb.AddForce (sidewyasForce * Time.deltaTime, 0 , 0,  ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))  // going left
        {
            rb.AddForce (-sidewyasForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
        }
    }
}

