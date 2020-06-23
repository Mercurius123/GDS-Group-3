using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialGuide : MonoBehaviour
{
    public GameObject blockText;

    void OnTriggerEnter(Collider other)
    {
        blockText.SetActive(true);
    }


    void OnTriggerExit(Collider other)
    {
        blockText.SetActive(false);
    }


}
