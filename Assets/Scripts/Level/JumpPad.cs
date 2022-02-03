using System;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
  [SerializeField] private float JumpForce = 1500f;
  

  private void OnTriggerEnter(Collider other)
  {

    var otherRigidbody = other.GetComponent<Rigidbody>();
    if(otherRigidbody != null)
      otherRigidbody.AddForce(transform.up * JumpForce);

  }
}
