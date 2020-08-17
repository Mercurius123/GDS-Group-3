using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainPlayerFunctions : MonoBehaviour
{
    
    public Text countText;
    public Text winText;
    private Rigidbody rb;
    public int count;
    public Text Objective;
    public int level;
   
    void Start()
    {
        

        rb = GetComponent<Rigidbody>();
        count = 0;
        level = 1;
        SetCountText();
        winText.text = "";

        
    }

    void Update()
    {
        
       

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

            
        }

      

    }
    void SetCountText()
    {
        countText.text = "Garbage Collected: " + count.ToString();
        if (count >= 10)
        {
            level = level + 1;
            Objective.text = level.ToString();
        }
        if (count >= 25)
        {
            level = level + 1;
            Objective.text = level.ToString();
        }
        if (count >= 40)
        {
            level = level + 1;
            Objective.text = level.ToString();
        }
        if (count >= 60)
        {
            level = level + 1;
            Objective.text = level.ToString();
        }
        if (count >= 80)
        {
            level = level + 1;
            Objective.text = level.ToString();
        }
        if (count >= 100)
        {
            level = level + 1;
            Objective.text = level.ToString();
        }
        if (count >= 130)
        {
            level = level + 1;
            Objective.text = level.ToString();
        }
        if (count >= 160)
        {
            level = level + 1;
            Objective.text = level.ToString();
        }
        if (count >= 200)
        {
            level = level + 1;
            Objective.text = level.ToString();
        }
    }
}
