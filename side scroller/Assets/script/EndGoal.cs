using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGoal : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter(Collider other) {
    if(other.gameObject.CompareTag("Player")){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
Debug.Log("You are win!");
    }
   }

   
}
