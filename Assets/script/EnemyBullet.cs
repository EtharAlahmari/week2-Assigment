using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
   [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifeSpan;
    private Rigidbody rb;
    private PlayerHealth PlayerHealthScript;
    void Start()
    {
       rb= GetComponent<Rigidbody>();
       rb.AddForce(transform.forward*bulletSpeed);
       Invoke("Delete",bulletLifeSpan);
    }

    private void Delete(){
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")){
            PlayerHealthScript=other.gameObject.GetComponent<PlayerHealth>();
            PlayerHealthScript.health--;
            Destroy(gameObject);
        }
    }
}
