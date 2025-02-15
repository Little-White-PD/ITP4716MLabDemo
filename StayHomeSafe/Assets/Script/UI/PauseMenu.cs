﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject Gameover;
    public GameObject stop;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            stop.SetActive(false);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("InGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
