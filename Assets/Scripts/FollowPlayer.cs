using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;  // this obect stores 3 floats it in, we use it for positional data

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position); // prints the postion of the game object tied to player to the console
        // give the position of the game object this script is sitting on (camera) the position of the game object we want it to follow
        // transform.position = player.position; // first person view

        transform.position = player.position + offset;  // we choose the offset in unity. vector addition takes place
    }
}
