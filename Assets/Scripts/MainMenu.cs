using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text highScore;
    public bool audioSound = true;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Score").ToString();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
    public void enableSound(bool sound_)
    {
        audioSound = sound_;
    }
}
