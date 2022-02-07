using UnityEngine;
using UnityEngine.Events;

public class ChargeJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private float minimumJumpForce = 100f;
    [SerializeField] private float maximumJumpForce = 1000f;
    [SerializeField] private float chargeTime = 1f;
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private UnityEvent<float> onChargeJump;
    private float jumpCharge;
    
    void Update()
    {
        HandleChargedJump();
    }

    private void HandleChargedJump()
    {
        if (commandContainer.jumpCommand)
        {
            jumpCharge += Time.deltaTime / chargeTime;
            jumpCharge = Mathf.Clamp01(jumpCharge);
        }
        
        if (commandContainer.jumpCommandUp)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            
            if (groundChecker.Isgrounded)
            {
                myRigidbody.AddForce(Vector3.up * jumpForce);
                onChargeJump.Invoke(jumpCharge);
            } 
            
            jumpCharge = 0f;
        }
    }
}
