using UnityEngine;

public class ChargeJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
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
        if (commandContainer.jumpCommand)
            jumpCharge += Time.deltaTime / chargeTime;

        if (commandContainer.jumpCommandUp)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            jumpCharge = 0f;
            if (groundChecker.Isgrounded)
                myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}