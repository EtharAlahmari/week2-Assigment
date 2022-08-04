using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeLevel : MonoBehaviour
{
    [SerializeField] private string Level1,Level2;
    [SerializeField] private KeyCode one,two;

    void Update()
    {
  
    if(Input.GetKeyDown(one))    
    SceneManager.LoadScene(Level1);

     if(Input.GetKeyDown(two))    
    SceneManager.LoadScene(Level2);



    }
}
