using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    // must be public so we can add it as an on-click event for the button in unity
    {
        Application.Quit();  // quits the game
        Debug.Log("THE USER HAS QUIT THE GAME");
    }
}
