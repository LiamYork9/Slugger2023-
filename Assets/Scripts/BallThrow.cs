using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public float thrust = -1.0f;
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