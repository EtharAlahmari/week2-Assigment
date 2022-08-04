using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
   [SerializeField] private float speed;
   private Rigidbody rb;
   private float facing;
  private void Start() {
    rb = GetComponent<Rigidbody>();
   }
private void Update() {
    Vector2 movement= new Vector2 (Input.GetAxis("Horizontal")*speed,0);
    rb.velocity= new Vector2(movement.x, rb.velocity.y);
    if(movement.x != 0)
      facing=Mathf.Atan2(movement.x, 0)* Mathf.Rad2Deg;

    rb.rotation= Quaternion.Euler(0,facing,0);  
}
}
