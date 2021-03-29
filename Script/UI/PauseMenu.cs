using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
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
}
