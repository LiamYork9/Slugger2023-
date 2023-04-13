using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnBall : MonoBehaviour


{
    public GameObject ballPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(ballPrefab, transform.position, Quaternion.identity);
        }
    }
}
