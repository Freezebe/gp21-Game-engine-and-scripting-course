using System;
using UnityEngine;

public class MoveTowardsPlayerAI : MonoBehaviour
{
   [SerializeField] private CommandContainer commandContainer;

   [SerializeField]private Transform playerTransform;

   private void Start()
   {
      //playerTransform = GameObject.FindWithTag("Player").transform;
      //playerTransform = GameObject.Find("Player").transform;
      //playerTransform = ((PlayerIdentifierComponent)FindObjectOfType(typeof(PlayerIdentifierComponent))).transform;
      //playerTransform = FindObjectOfType<PlayerInputController>().transform;
   }

   private void Update()
   {
      
      
      
      var directionToPlayer = playerTransform.position - transform.position;
      directionToPlayer.Normalize();
      var horizontalDirectionToPlayer = directionToPlayer.x;

      commandContainer.walkCommand = horizontalDirectionToPlayer;
   }
}
