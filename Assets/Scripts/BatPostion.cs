using System.Collections.Specialized;
using UnityEngine;

public class BatPostion : MonoBehaviour
{
    public float speed = 0.006f;
    Vector3 bpos;

    // Update is called once per frame
    void Update()
    {
        bpos = transform.position;


        float xDirection = Input.GetAxis("Horizontal");
        bpos.x = Mathf.Clamp(bpos.x, -2.3f, 0.08f);
        
        //float yDirection = Input.GetAxis("Vertical");
      
        Vector3 moveDirection = new Vector3(xDirection, 0.0f);
        bpos += moveDirection * speed ;

        transform.position = bpos;

     

    }
}
