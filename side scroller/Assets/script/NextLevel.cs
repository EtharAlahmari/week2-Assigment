using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    [SerializeField] private string thenextLevel;
   private void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("Player"))
       SceneManager.LoadScene(thenextLevel);
   }
}
