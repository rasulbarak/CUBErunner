using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject GetReadyUI;
    public AudioSource _audio;
    
    public void StartGame()
    // must be public to be added as an on-click event
    {
        _audio.enabled = true;
        GetReadyUI.SetActive(true);
        Invoke("LoadGameScene", 2);

    }

    public void LoadGameScene()
    {
        // SceneManager.LoadScene(0); i.e. load the scene with build index 0. OR
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   // load the scene with the next build index (set up build profile correctly)
        // preferred because thin this way we can just chanage the build profile in order to change which scene get loaded when rather than changin code.
    }
}
