using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
   private PlayerHealth  playerHealthScript;
  
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
     playerHealthScript = other.gameObject.GetComponent<PlayerHealth>();
     playerHealthScript.health++;
     Destroy(gameObject);

    }
   
}
