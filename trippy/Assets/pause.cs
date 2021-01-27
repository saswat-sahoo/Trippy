using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject PauseMenueUI;
    public new AudioSource audio;
    void Update()
    {
        if (PauseMenueUI.activeInHierarchy == false)
        {
            Time.timeScale = 1f;
            GameIsPaused = false;
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }

        }
    }

    public void Resume()
    {
        PauseMenueUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        audio.Play();


    }
    void Pause()
    {
        PauseMenueUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        audio.Pause();

    }
    public void Quit()
    {
        Application.Quit();
    }


}
