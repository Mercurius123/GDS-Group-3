using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Opsive.Shared.Events;
using Opsive.UltimateCharacterController.Input;

public class MenuControl : MonoBehaviour
{
    [SerializeField] GameObject mainMenu, pauseMenu, characterMenu, craftMenu, encycloMenu, controlsMenu, creditsMenu, background, bars, countText, objective;
    public bool menuActive = false, craftMenuActive = false;
    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        Scene currentscene = SceneManager.GetActiveScene();
        sceneName = currentscene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (menuActive == true || sceneName == "StartScene")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if (Input.GetKeyUp("escape") && sceneName == "MAIN")
        {
            if(menuActive == false)
            {
                pauseMenu.SetActive(true);
                background.SetActive(true);
                bars.SetActive(false);
                countText.SetActive(false);
                objective.SetActive(false);
                menuActive = true;               
                PauseGame();
                
            }
            else
            {
                pauseMenu.SetActive(false);
                characterMenu.SetActive(false);
                craftMenu.SetActive(false);
                encycloMenu.SetActive(false);
                controlsMenu.SetActive(false);
                background.SetActive(false);
                bars.SetActive(true);
                countText.SetActive(true);
                objective.SetActive(true);
                menuActive = false;
                ResumeGame();
            }
        }

        if (Input.GetKeyUp("escape") && sceneName == "StartScene")
        {
            if (mainMenu.activeSelf == true)
            {
                Debug.Log("do nothing");
            }
            else
            {
                creditsMenu.SetActive(false);
                mainMenu.SetActive(true);
            }
        }

        if(Input.GetKeyUp("i") && menuActive == false)
        {
            characterMenu.SetActive(true);
            background.SetActive(true);
            menuActive = true;
          
            PauseGame();
        }

        if (craftMenuActive == true && menuActive == false)
        {
            craftMenu.SetActive(true);
            background.SetActive(true);
            menuActive = true;
            craftMenuActive = false;
            bars.SetActive(false);
            countText.SetActive(false);
            objective.SetActive(false);

            PauseGame();
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        bars.SetActive(true);
        countText.SetActive(true);
        objective.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void LeaveGame()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void NewGame()
    {
        SceneManager.LoadScene("LoadingScreen");
    }

    public void ActiveSwitch()
    {
        menuActive = !menuActive;        
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
