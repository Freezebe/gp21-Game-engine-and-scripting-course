using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody myRigidbody;
    public float jumpForce = 500f;
    private void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);

        if (jumpInput && myRigidbody.velocity.y == 0)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
