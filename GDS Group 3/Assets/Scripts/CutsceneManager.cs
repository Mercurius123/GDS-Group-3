using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject MainCam;
    public GameObject subText;
    public GameObject textPanel;
    public GameObject tutorial;
    void Start()
    {
        StartCoroutine(TheSequence());
        {
            
        }

        Cam1.SetActive(true);
    }

    private IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(1);
        subText.SetActive(true);
        textPanel.SetActive(true);
        tutorial.SetActive(false);
        subText.GetComponent<Text>().text = "Greetings Employee, Welcome to your new job at GACC. You have been tasked with cleaning the dying waters off New Zealand's coast. Now you wont notice any immediate benefits but trust me, It will all be worth it in the end. ";
        yield return new WaitForSeconds(4);
        Cam2.SetActive(true);
        Cam1.SetActive(false);
        subText.GetComponent<Text>().text = "This is your player hub. It lets you deposit your garbage as well as craft new tools to help you in your journey. ";
        yield return new WaitForSeconds(2);
        Cam3.SetActive(true);
        Cam2.SetActive(false);
        subText.GetComponent<Text>().text = "This is your player hub. It lets you deposit your garbage as well as craft new tools to help you in your journey. ";
        yield return new WaitForSeconds(4);
        Cam3.SetActive(false);
        Cam4.SetActive(true);
        subText.GetComponent<Text>().text = "You'll find plenty of garbage to collect in these parts of the ocean. Good luck getting rid of them! ";
        yield return new WaitForSeconds(6);
        Cam4.SetActive(false);
        MainCam.SetActive(true);
        subText.SetActive(false);
        textPanel.SetActive(false);
        tutorial.SetActive(true);
    }
    
}
