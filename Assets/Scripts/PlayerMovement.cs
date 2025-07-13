using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    // create a reference for out Rigidbody
    public Rigidbody rb;

    public float forwardForce = 300;
    public float sidewaysForce = 500;
    // will store whether the player wants to move left or right
    bool rightMove = false;
    bool leftMove = false;

    /*
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log("Hello, World");  // displayes a message in our unity console

        // disable gravity
        // rb.useGravity = false;
        rb.AddForce(0, 200, 500);
    }
    */

    void Update()
    {
        // since update runs faster than FixedUpdate we need to do this in order
        // not to lose user input
        // Move character based on user input using Input class
        if (Input.GetKey("d"))
        {
            rightMove = true;
        }
        else
        {
            rightMove = false;
        }
        if (Input.GetKey("a"))
        {
            leftMove = true;
        }
        else
        {
            leftMove = false;
        }

        if (rb.position.y <= -1f)   // return the y value of the rigid body's center of mass (has not been offset for us so it is the same as Transform.position.y)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    // Update is called once per frame: i.e. whenever my mac draws a new image
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        
        if (rightMove)
        {
            // move right if rightMove is true
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (leftMove)
        {
            // move left if leftMove is true
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
    }
}
