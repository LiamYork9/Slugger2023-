using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    public GameObject ball; 
    public bool stopSpawing = false;
    public float spawnTime;
    public float spawnDelay;

    void Start(){
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    
        
        public void SpawnObject()
        {
        Instantiate(ball, transform.position, Quaternion.identity);
        if (stopSpawing) {
            CancelInvoke("SpawnObject");
            }
        }
    

  
}

