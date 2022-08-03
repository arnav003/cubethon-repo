using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // it is refewrence to the component rigidbidy
    public Rigidbody rb;


    // variable to store the value of force applied on the body
    public float forwardForce = 2000f;

    //
    public float sidewaysForce = 500f;


    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {


        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // to move the cube towards right
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
         

        // to move the cube towards left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }

        if (rb.position.y < -1F)
        {
            FindObjectOfType<GameManager>().EndGame();


        }


    }
}
