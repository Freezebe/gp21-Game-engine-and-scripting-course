using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private GroundChecker groundChecker;
    void Update()
    {
        
        
        if (playerInputController.JumpInputDown && groundChecker.Isgrounded)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
        
    }
}
