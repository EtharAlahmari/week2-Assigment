using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyPatrol : MonoBehaviour
{

    private GameObject player;
    [SerializeField] private float speed;
    private bool detected=false;
    void Start()
    {
    player= GameObject.FindWithTag("Player");    
    }

    // Update is called once per frame
    void Update()
    {
     float playerDistance= Vector3.Distance(player.transform.position, transform.position);  
      if(playerDistance <= 10 && detected ==false)
         detected= true;
    if(detected==true){
        if(player.transform.position.x<transform.position.x)
        transform.Translate(Vector3.right *-speed*Time.deltaTime);
        else
          transform.Translate(Vector3.right*speed*Time.deltaTime); 
    }
     
     Debug.Log("Distance between player and enemy is: "+playerDistance);
    }
}
