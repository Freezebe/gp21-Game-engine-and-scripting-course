using System;
using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public Rigidbody myRigidbody;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private float chargingMoveSpeedFactor = 0.5f;
    [SerializeField] private GroundChecker _groundChecker;

    void Update()
    {
        HandleWalking();
    }

    private void HandleWalking()
    {
        var currentMoveSpeed = moveSpeed;
        if (playerInputController.jumpInput && _groundChecker.Isgrounded)
            currentMoveSpeed *= chargingMoveSpeedFactor;
        
        myRigidbody.velocity = new Vector3(playerInputController.moveInput * currentMoveSpeed, myRigidbody.velocity.y, 0);

    }
    
}
