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
    private int count;
    public Text Objective;
    

    


    


    
    void Start()
    {
        

        rb = GetComponent<Rigidbody>();
        count = 0;

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
        if (count >= 12)
        {
            Objective.text = "Collect Garbage in the Coral Forests located in the direction your hub is facing.";
        }

    }
}
