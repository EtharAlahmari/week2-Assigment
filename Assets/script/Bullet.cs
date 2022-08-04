using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifeSpan;
    private Rigidbody rb;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed);
        Invoke("Delete",bulletLifeSpan);
    }
    private void Delete(){
        Destroy(gameObject);
    }

   private void OnCollisionEnter(Collision other) {
    if(other.gameObject.CompareTag("Enemy"))
    Destroy(other.gameObject);
    Destroy(gameObject);
   }
}
