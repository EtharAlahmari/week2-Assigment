using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    private PlayerMovement2D playScript;
   private void OnCollisionEnter(Collision other) {
     if(other.gameObject.CompareTag("Player")){
        player=other.gameObject;
        rb=player.GetComponent<Rigidbody>();
        playScript =player.GetComponent<PlayerMovement2D>();

        PushPlayer();
     }
   }

   private void PushPlayer(){
    playScript.enabled=false;
    rb.AddForce(Vector3.up*250);
    if(player.transform.position.x<transform.position.x)
    rb.AddForce(Vector3.right* -500);
    else
    rb.AddForce(Vector3.right*500);

    Invoke("MoveAgain",1);
   }

   private void MoveAgain(){
    playScript.enabled=true;
   }
}
