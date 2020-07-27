using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallMechanics : MonoBehaviour
{
    
    public Text countText;
    public Text winText;
    private Rigidbody rb;
    private int count;
    

    


    public AudioSource tickSource;


    
    void Start()
    {
        

        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winText.text = "";

        tickSource = GetComponent<AudioSource>();
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

            tickSource.Play ();
        }

      

    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 20)
        {
            SceneManager.LoadScene("End");
            Cursor.visible = true;
        }

    }
}
