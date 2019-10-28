
using UnityEngine;

public class hamstermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fx = 100f;
    public float fy = 100f;
    public float fz = 100f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("j"))
        {  
            rb.AddForce(0, fy * Time.deltaTime, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-fx * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(fx * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, fz * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -fz * Time.deltaTime);
        }  }
}
