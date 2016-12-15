using UnityEngine;
using System.Generic;

class ProjectileTest() {

  RayHit hit; // Test For Later
  GameObject pc;
  Vector3 PlayeLocation = (pc.x, pc.y, pc.z);
  Vector3 ProjectileLocation = (Vector3.forward);

  // Updates after every frame
  void Update() {
    if(Input.GetKey(KeyCode.E)) {
      // Create an instance of an object, and place at the location while relative to the rotation of the player object at the speed () Float
      instantiate(new prefab, Vector3(Quaternion.Euler+(pc.x), Quaternion.Euler+(pc.y), ProjectileLocation) 5.0f);
    
    // RayCast new(PlayerLocation, ProjectileLocation, 28.0f, 200f, hit); // No information on hit
    }
  }
  
}
