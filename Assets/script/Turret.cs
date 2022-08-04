using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bullet;
    private Transform player;
    private bool detected= false;
    void Start()
    {
        player=GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
      transform.LookAt(player); 
      DetectingPlayer(); 
    }
    private void DetectingPlayer(){
        float playerDistance= Vector3.Distance(player.transform.position,transform.position);
        if(playerDistance <= 15 &&  detected == false){
            detected=true;
            InvokeRepeating("Shooting",0,1);
        }
        else if (playerDistance>15){
          detected=false;
          CancelInvoke("Shooting");
        }
    }
    private void Shooting(){
        Instantiate(bullet,bulletSpawnPoint.position,bulletSpawnPoint.rotation);
    }
}
