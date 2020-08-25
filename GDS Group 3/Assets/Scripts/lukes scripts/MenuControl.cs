using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Opsive.Shared.Events;
using Opsive.UltimateCharacterController.Input;

public class MenuControl : MonoBehaviour
{
    [SerializeField] GameObject mainMenu, pauseMenu, saveMenu, loadMenu, characterMenu, craftMenu, encycloMenu, controlsMenu, creditsMenu, background, bars, countText, objective, level;
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
        if (menuActive == true)
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
                level.SetActive(false);                
                PauseGame();
                menuActive = true;
            }
            else
            {
                pauseMenu.SetActive(false);
                saveMenu.SetActive(false);
                loadMenu.SetActive(false);
                characterMenu.SetActive(false);
                craftMenu.SetActive(false);
                encycloMenu.SetActive(false);
                controlsMenu.SetActive(false);
                background.SetActive(false);
                bars.SetActive(true);
                countText.SetActive(true);
                objective.SetActive(true);
                level.SetActive(true);
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
                loadMenu.SetActive(false);
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
            level.SetActive(false);

            PauseGame();
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        bars.SetActive(true);
        countText.SetActive(true);
        objective.SetActive(true);
        level.SetActive(true);
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
