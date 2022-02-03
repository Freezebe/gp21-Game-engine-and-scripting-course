using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private GroundChecker groundChecker;
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        if (commandContainer.jumpCommandDown && groundChecker.Isgrounded)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
