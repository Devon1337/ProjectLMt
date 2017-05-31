using UnityEngine;
using System.Generic;

class 3dPC() {

  // Public Movement/Rotation of an object; Defined in the engine;
  public Transform playerObject, playerCamera;
  // Speed of the camera and player
  public float speed, turnSpeed;
  // Player Direction
  Vector3 forceDirection;
  // PlayerController
  GameObject player;

  // Every Given Update
  void FixedUpdate() {
    transform.position = playerObject.position;
    if(Input.GetAxis("Vertical")) {
      MovePlayer();
    }
  
  }
  
  void MovePlayer() {
    // Moves the Player And the PlayerCamera To assign a location Around a Centralized Object.
    forceDirection = playerCamera.transform.forward;
    forceDirection = new Vector3(forceDirection.x, 0, forceDirection.z);
    
    // Checks for a rigidbody to be applied to a GameObject and places a direction force
    playerController.GetComponent<Rigidbody>().AddForce(forceDirection.normalized * speed * (Input.GetAxis("Vertical")));
  }

}
