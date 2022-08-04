using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
   private Rigidbody rb;
  private void Start() {
    rb = GetComponent<Rigidbody>();
   // rb.AddForce(Vector3.up*500);
    rb.AddForce(transform.forward*500);
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
