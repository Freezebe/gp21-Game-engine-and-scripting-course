using System;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
   public bool Isgrounded { get; private set; }
   [SerializeField] private float groundCheckLength = 1f;
   [SerializeField] private float groundCheckRadius = 0.5f;
   [SerializeField] private LayerMask groundLayers;
    void Update()
    {
        CheckIfGrounded();
    }

    private void CheckIfGrounded()
    {
        var ray = new Ray(transform.position, Vector3.down);
        Isgrounded = Physics.SphereCast(ray, groundCheckRadius, groundCheckLength, groundLayers);

        //Debug.DrawRay(transform.position, Vector3.down * groundCheckLength, Color.magenta);
    }

    // private void OnDrawGizmos()
    // {
    //     Gizmos.DrawSphere(transform.position + Vector3.down * groundCheckLength, groundCheckRadius);
    // }
}
