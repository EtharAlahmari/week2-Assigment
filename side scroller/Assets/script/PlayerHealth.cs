using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHealth : MonoBehaviour
{   
   public int health;
   [SerializeField] private Transform spawnPoint;
    private Rigidbody rb;
    private PlayerMovement2D playScript;
     private Transform enemy;

      private void Start()
    {
        rb=GetComponent<Rigidbody>();
        playScript=GetComponent<PlayerMovement2D>();
    }
   private void Update()
    {
      if(health<=0)
       Die();  
    }
    private void Die(){
     transform.position=spawnPoint.position;
     health= 3;
    }
     private void Damage(){
         playScript.enabled=false;
    rb.AddForce(Vector3.up*250);
    if(transform.position.x<enemy.position.x)
    rb.AddForce(Vector3.right* -500);
    else
    rb.AddForce(Vector3.right* 500);

    Invoke("MoveAgain",1);
     }

       private void MoveAgain(){
    playScript.enabled=true;
   }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Enemy")){
       health--;
      enemy= other.gameObject.transform;
      Damage();
        }
       
       // Debug.Log("heath now is:"+health );
    }
}
