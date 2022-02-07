using UnityEngine;
using UnityEngine.Events;

public class ImmediateJumpController : MonoBehaviour
{
    
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private UnityEvent onJump;
    
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        if (commandContainer.jumpCommandDown && groundChecker.Isgrounded)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
            onJump.Invoke();
        }
    }
}
