using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private float minimumJumpForce = 100f;
    [SerializeField] private float maximumJumpForce = 1000f;
    [SerializeField] private float chargeTime = 1f;
    [SerializeField] private GroundChecker groundChecker;
    private float jumpCharge;
    
    void Update()
    {
        HandleChargedJump();
    }

    private void HandleChargedJump()
    {
        if (playerInputController.jumpInput)
            jumpCharge += Time.deltaTime / chargeTime;

        if (playerInputController.JumpInputUp)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            jumpCharge = 0f;
            if (groundChecker.Isgrounded)
                myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
