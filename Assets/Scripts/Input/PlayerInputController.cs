using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;
    
    // currently not in use, just left as an example.
     public float walkInput { get; private set; }
     public bool JumpInputDown { get; private set; }
     public bool JumpInputUp { get; private set; }
     public bool jumpInput { get; private set; }
    void Update()
    {
        GetInput();
        SetCommands();
    }

    private void GetInput()
    {
        walkInput = Input.GetAxis("Horizontal");
        JumpInputDown = Input.GetKeyDown(KeyCode.Space);
        JumpInputUp = Input.GetKeyUp(KeyCode.Space);
        jumpInput = Input.GetKey(KeyCode.Space);
    }

    private void SetCommands()
    {
        commandContainer.walkCommand = walkInput;
        commandContainer.jumpCommand = jumpInput;
        commandContainer.jumpCommandDown = JumpInputDown;
        commandContainer.jumpCommandUp = JumpInputUp;

    }
}
