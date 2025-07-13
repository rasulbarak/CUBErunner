using UnityEngine;

public class AddMovement : MonoBehaviour
{

    public Transform leftBoundary;
    public Transform rightBoundary;

    public float speed = 2f;

    
    private bool movingRight = true; // start by moving rightwards
    private Vector3 targetPosition;    // will hold the position to move towards


    void FixedUpdate()
    {
        // set the position to move towards
        if (movingRight)
        {
            targetPosition = rightBoundary.position;
        }
        else
        {
            targetPosition = leftBoundary.position;
        }

        // move towards the target positon
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // change targetPosition to other boundary if we reach it
        if (Vector3.Distance(transform.position, targetPosition) < 1f)
        {
            // switch direction
            movingRight = !movingRight; // i.e. it is false so the else block will execute;
        }
    }
}
