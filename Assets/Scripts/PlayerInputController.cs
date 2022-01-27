using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
     public float moveInput { get; private set; }
     public bool JumpInputDown { get; private set; }
     public bool JumpInputUp { get; private set; }
     public bool jumpInput { get; private set; }
    void Update()
    {
         moveInput = Input.GetAxis("Horizontal");
         JumpInputDown = Input.GetKeyDown(KeyCode.Space);
         JumpInputUp = Input.GetKeyUp(KeyCode.Space);
         jumpInput = Input.GetKey(KeyCode.Space);

    }
}
