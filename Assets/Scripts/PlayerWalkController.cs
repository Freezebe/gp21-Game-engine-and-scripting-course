using System;
using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public Rigidbody myRigidbody;
    [SerializeField] private PlayerInputController playerInputController;

    void Update()
    {

        myRigidbody.velocity = new Vector3(playerInputController.moveInput * moveSpeed, myRigidbody.velocity.y, 0);
        
    }
}
