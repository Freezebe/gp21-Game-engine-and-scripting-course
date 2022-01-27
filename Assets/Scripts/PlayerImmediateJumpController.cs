using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float jumpForce = 500f;
    void Update()
    {
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        
        if (jumpInput && myRigidbody.velocity.y == 0)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
        
    }
}
