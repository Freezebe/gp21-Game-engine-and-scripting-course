using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody myRigidbody;
    void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");
        
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);
        
    }
}
