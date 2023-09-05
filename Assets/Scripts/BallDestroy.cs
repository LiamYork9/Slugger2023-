using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Vector3.zero,transform.position) > 30)
            Destroy(gameObject);
    }
}
