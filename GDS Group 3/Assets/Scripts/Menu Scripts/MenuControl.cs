using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField] GameObject mainMenu, pauseMenu, saveMenu, loadMenu, characterMenu, craftMenu, encycloMenu, controlsMenu, creditsMenu, background, craftingBench;
    public bool menuActive = false;
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
        if (Input.GetKeyUp("escape") && sceneName == "MAIN")
        {
            if(menuActive == false)
            {
                pauseMenu.SetActive(true);
                background.SetActive(true);
                menuActive = true;
                PauseGame();
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

        if (Input.GetKeyUp("k") && menuActive == false)
        {
            craftMenu.SetActive(true);
            background.SetActive(true);
            menuActive = true;
            PauseGame();
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
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
        SceneManager.LoadScene("MAIN");
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
