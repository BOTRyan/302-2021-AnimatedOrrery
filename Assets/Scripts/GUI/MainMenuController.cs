using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public AudioSource boop;

    void playBoop()
    {
        boop.pitch = Random.Range(.25f, 1.25f);
        boop.Play();
    }
    public void BttnPlay()
    {
        toGame();
    }
    public void toGame()
    {
        playBoop();
        Invoke("loadGame", 1);
    }
    public void loadGame()
    {
        SceneManager.LoadScene("AnimatedOrrery");
    }
    public void BttnQuit()
    {
        playBoop();
        Invoke("QuitProgram", 1);
    }
    public void QuitProgram()
    {
        if (UnityEditor.EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
}
