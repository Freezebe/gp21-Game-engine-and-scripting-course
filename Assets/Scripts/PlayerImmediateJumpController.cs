using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private float jumpForce = 500f;
    void Update()
    {
        
        
        if (playerInputController.jumpInput && myRigidbody.velocity.y == 0)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
        
    }
}
