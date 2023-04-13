using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BatForce : MonoBehaviour
{
    [SerializeField] float speed;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(speed * Vector3.forward, ForceMode.Impulse);
        }
    }
}
