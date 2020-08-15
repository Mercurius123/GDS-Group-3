using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialGuide : MonoBehaviour
{
    public GameObject blockText;
    public GameObject GameText;
    public GameObject Trigger;

    void OnTriggerEnter(Collider other)
    {
        blockText.SetActive(true);
        GameText.SetActive(false);
    }


    void OnTriggerExit(Collider other)
    {
        blockText.SetActive(false);
        GameText.SetActive(true);
        Trigger.SetActive(false);
    }


}
