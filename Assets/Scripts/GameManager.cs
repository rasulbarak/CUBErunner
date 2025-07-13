using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;  // wil keep track if game has ended or not so that EndGame() so we display Game Over only once
    public float restartDelay = 1f;

    public GameObject completeLevelUI;  // a reference variable to our panel game object

    public void CompletedLevel()
    {
        completeLevelUI.SetActive(true);    // enable the Game Object (display the panel)
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            // Debug.Log("GAME OVER");
            gameHasEnded = true;    // Game Over will now not be shown repeatedly since although EndGame will be called
                                    // the code inside the if statement won't be executed.
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // return the name of the current scene after retreiving the current scene
                                                                    // then pass it on to the LoadScene static method.
    }
}
