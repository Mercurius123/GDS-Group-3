using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltips : MonoBehaviour
{
    public Text tooltipTxt;
    public Text toolDescTxt;
    void Start()
    {
        tooltipTxt.enabled = false;
        toolDescTxt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MouseOverSlot1()
    {
        tooltipTxt.enabled = true;
        toolDescTxt.enabled = true;

        tooltipTxt.text = "Tool 1";
        toolDescTxt.text = "The First Tool of the Player!";

        //Debug.Log("mouseOver");
    }

    public void MouseOverSlot2()
    {
        tooltipTxt.enabled = true;
        toolDescTxt.enabled = true;

        tooltipTxt.text = "Tool 2";
        toolDescTxt.text = "The Second Tool of the Player!";

        //Debug.Log("mouseOver");
    }

    public void MouseOverSlot3()
    {
        tooltipTxt.enabled = true;
        toolDescTxt.enabled = true;

        tooltipTxt.text = "Tool 3";
        toolDescTxt.text = "The Third Tool of the Player!";

        //Debug.Log("mouseOver");
    }

    public void MouseOverSlot4()
    {
        tooltipTxt.enabled = true;
        toolDescTxt.enabled = true;

        tooltipTxt.text = "Tool 4";
        toolDescTxt.text = "The Fourth Tool of the Player!";

        //Debug.Log("mouseOver");
    }

    public void MouseOverSlot5()
    {
        tooltipTxt.enabled = true;
        toolDescTxt.enabled = true;

        tooltipTxt.text = "Tool 5";
        toolDescTxt.text = "The Fifth Tool of the Player!";

        //Debug.Log("mouseOver");
    }

    public void DisableToolText()
    {
        toolDescTxt.enabled = false;
        tooltipTxt.enabled = false;
    }
}
