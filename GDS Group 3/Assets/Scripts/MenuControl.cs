using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField] GameObject playerController;
    [SerializeField] GameObject background;
    [SerializeField] GameObject craftMenu;
    [SerializeField] GameObject charMenu;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject saveMenu;
    [SerializeField] GameObject loadMenu;
    [SerializeField] GameObject encycloMenu;
    [SerializeField] GameObject controlsMenu;
    [SerializeField] GameObject UICamera;
    bool paused;
    
     
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (paused)
            {
                background.SetActive(false);
                craftMenu.SetActive(false);
                charMenu.SetActive(false);
                pauseMenu.SetActive(false);
                saveMenu.SetActive(false);
                loadMenu.SetActive(false);
                encycloMenu.SetActive(false);
                controlsMenu.SetActive(false);
                ResumeGame();
            }
            else
            {
                background.SetActive(true);
                pauseMenu.SetActive(true);
                PauseGame();
            }
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            charMenu.SetActive(true);
            background.SetActive(true);
            PauseGame();
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            craftMenu.SetActive(true);
            background.SetActive(true);
            PauseGame();
        }
    }
        
    public void PauseGame()
    {
        playerController.GetComponent<FirstPersonAIO>().ControllerPause();
        paused = true;
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        playerController.GetComponent<FirstPersonAIO>().ControllerPause();
        paused = false;
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene("MAIN");
    }

    public void LeaveGame()
    {
        SceneManager.LoadScene("StartScene");
    }
}
