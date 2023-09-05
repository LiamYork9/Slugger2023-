using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnBall : MonoBehaviour


{
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(ball, transform.position, Quaternion.identity);
        }
      
    }
}
