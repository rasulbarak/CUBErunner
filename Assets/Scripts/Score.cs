using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // reference to Transform information of our Player object
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position.z);  // Displays player game object's position along the z axis.
        scoreText.text = player.position.z.ToString("0");
    }
}
