using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayAgain : MonoBehaviour
{
    public GameObject GetReadyUI;   // will reference the GetReady Panel
    public AudioSource _audio;  // will control the audio

    public void Restart()
    // load the scene with build index 1, make method pubclic so it can be added as an on-click event
    {
        _audio.enabled = true;  // play the sound
        GetReadyUI.SetActive(true);

        Invoke("GoToLevel1", 2);    // call the below function with a delay;
    }

    void GoToLevel1()
    {
        SceneManager.LoadScene(1);  // load the scene with build index 1 i.e. level1
    }

}
