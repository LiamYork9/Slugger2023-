using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public float thrust = 0f;
    public float push = 0f;
    public Rigidbody rb;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bat"))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(0, 0, push, ForceMode.Impulse);


            
        }
        enabled = false;
    }

   private void Update()
    {


        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);

    }

}