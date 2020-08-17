using Opsive.UltimateCharacterController.Demo.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    GameObject menuObject;
    public MenuControl craftingMenuOpened;
    public GameObject collision;
    public Transform Player;
    public Text GUIText;
    public Text MatterCountText;
    public int carriedGarbageCount;
    public int maxGarbageCount;
    public int Matter;
    public int smallGarbageValue = 10;
    public int largeGarbageValue = 50;
    public bool TPGunEquipped = false;

   
    
    // Start is called before the first frame update
    void Start()
    {
       Rigidbody rb = GetComponent<Rigidbody>();
       rb.isKinematic = false;
       craftingMenuOpened = menuObject.GetComponent<MenuControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionStay(Collision col)
    {
        Debug.Log("Collision with" + col.gameObject.name);
        collision = col.gameObject;
        if (col.gameObject.name == "Garbage Storage")
        {
            GUIText.text = ("Press F to Deposit Garbage");
            GUIText.gameObject.SetActive(true); 
            if (Input.GetKeyDown(KeyCode.F))
            {
                GarbageStorageUI();
            }
        }
        else if (col.gameObject.name == "CraftingBench")
        {
            GUIText.text = ("Press F to Craft Something");
            GUIText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("f worked");
                CraftingBenchUI();
                Debug.Log("something here didnt");
            }
        }
        else if (col.gameObject.tag == "LargeGarbage")
        {
            GUIText.text = ("Press F to Collect");
            GUIText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                LargeGarbageUI();
            }
        }
        else if (col.gameObject.tag == "SmallGarbage")
        {
            GUIText.text = ("Press F to Collect");
            GUIText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                SmallGarbageUI();
            }
        }
    }

    public void OnCollisionExit(Collision col)
    {
        GUIText.text = ("");
        GUIText.gameObject.SetActive(false);
    }
        
    public void GarbageStorageUI()
    {
        if (smallGarbageValue == 0)
        {
            GUIText.text = ("You have nothing to deposit");
            //StartCoroutine(SwapText());
        }
        else
        {
            Matter = Matter + (carriedGarbageCount * smallGarbageValue);
            carriedGarbageCount = 0;
            MatterCountText.text = ("Matter Count: " + Matter);
            GUIText.text = ("You have " + Matter + " total.");
            //StartCoroutine(SwapText());
        }
    }
    public void CraftingBenchUI()
    {        
        craftingMenuOpened.craftMenuActive = true;
        GUIText.text = ("");
        GUIText.gameObject.SetActive(false);
    }

    public void LargeGarbageUI()
    {
        if (TPGunEquipped == false)
        {
            GUIText.text = ("This is too Heavy to carry.");
            //StartCoroutine(SwapText());
        }
        else
        {
            Debug.Log("Teleported");
        }
    }

    public void SmallGarbageUI()
    {
        if(carriedGarbageCount < maxGarbageCount)
        {
            carriedGarbageCount = carriedGarbageCount + 1;
            Destroy(collision);
        }
        else
        {
            GUIText.text = ("You are carrying to much already!");
            //StartCoroutine(SwapText());
        }        
    }

    public IEnumerator SwapText()
    {
        
        yield return new WaitForSeconds(100);
    }
}
