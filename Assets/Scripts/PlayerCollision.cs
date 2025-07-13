using UnityEngine;



public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;    // create a PlayerMovement type that will reference that script
                                       // we will use this to affect that script based on this scipt

    public AudioSource _audio;  // will hold the audio component

    void OnCollisionEnter(Collision collisionInfo)
    // special function that is called whenever our game object collides with another game object
    // that has a collider and a RigidBody
    {
        // Debug.Log("We hit something");

        // displaying the name of the game object our game object collides with to the console
        // Debug.Log("we hit " + collisionInfo.collider.name); // .name returns a string

        // only print to the console if we hit a game object whose name is "obstacle"
        /*
        if (collisionInfo.collider.name == "Obstacle")
        {
            Debug.Log("We hit an obstacle");
        }
        */

        /*
        // check for the tag of the colliding game object instead, this allows us to do the same things for a group of objects
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle");
        }
        */

        if (collisionInfo.collider.tag == "Obstacle")
        {

            _audio.enabled = true;  // play collision sound

            // we disable (uncheck) the script that movement references
            movement.enabled = false;

            // Display game over by accessing the GameManager script in the GameManager object and calling the relevant method
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
