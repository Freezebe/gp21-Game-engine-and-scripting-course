using UnityEngine;

public class WalkController : MonoBehaviour
{
    // [SerializeField] public float walkSpeed = 5f;
    [SerializeField] private WalkSpeedSO walkSpeedSo;
    [SerializeField] public Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private float chargingWalkSpeedFactor = 0.5f;
    [SerializeField] private GroundChecker _groundChecker;

    void Update()
    {
        HandleWalking();
    }

    private void HandleWalking()
    {
        var currentMoveSpeed = walkSpeedSo.WalkSpeed;
        if (commandContainer.jumpCommand && _groundChecker.Isgrounded)
            currentMoveSpeed *= chargingWalkSpeedFactor;
        
        myRigidbody.velocity= new Vector3(commandContainer.walkCommand * currentMoveSpeed,myRigidbody.velocity.y,0);
    }
    
}
