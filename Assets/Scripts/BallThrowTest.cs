using UnityEngine;

public class BallThrowTest : MonoBehaviour
{
    public float thrust = -0.5f;
    public Rigidbody rb;

    void Update()
    {
        if (Input.GetButton("Jump"))
        {

            rb = GetComponent<Rigidbody>();
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        }


    }
}