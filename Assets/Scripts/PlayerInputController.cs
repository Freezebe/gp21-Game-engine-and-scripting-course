using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
     public float moveInput { get; private set; }
     public bool jumpInput { get; private set; }
    void Update()
    {
         moveInput = Input.GetAxis("Horizontal");
         jumpInput = Input.GetKeyDown(KeyCode.Space);
        
    }
}
