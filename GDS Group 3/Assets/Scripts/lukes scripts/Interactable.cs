using Opsive.UltimateCharacterController.Demo.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public GameObject menuObject;
    public GameObject collision;
    public Transform Player;
    public Text GUIText;
    public Text GUITextChange;
    public int changeTextTime;
    public Text MatterCountText;
    public int carriedGarbageCount;
    public int maxGarbageCount;
    public int Matter;
    public int smallGarbageValue = 10;
    public int largeGarbageValue = 50;
    public bool TPGunEquipped = false;
    public bool interactionHappened = false;
    public float GUITimer = 3;
    public float maxTimer = 3;
         
    
    void Start()
    {
       Rigidbody rb = GetComponent<Rigidbody>();
       rb.isKinematic = false;
    }

    void Update()
    {
        if (interactionHappened == true)
        {
            GUIText.gameObject.SetActive(false);
            GUITextChange.gameObject.SetActive(true);
            GUITimer -= Time.deltaTime;
            if (GUITimer <= 0)
            {
                GUITextChange.gameObject.SetActive(false);
                GUITextChange.text = ("");
                interactionHappened = false;
            }
        }
    }

    public void OnCollisionStay(Collision col)
    {
        Debug.Log("Collision with" + col.gameObject.name);
        collision = col.gameObject;
        if (interactionHappened == false)
        {
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
                    CraftingBenchUI();
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
        else
        {
            Debug.Log("displaying through update");
        }
    }

    public void OnCollisionExit(Collision col)
    {
        GUIText.text = ("");
        GUIText.gameObject.SetActive(false);
        GUITextChange.text = ("");
        GUITextChange.gameObject.SetActive(false);
        interactionHappened = false;
    }
        
    public void GarbageStorageUI()
    {
        if (carriedGarbageCount == 0)
        {
            GUITextChange.text = ("You have nothing to deposit");
            GUITimer = maxTimer;
            interactionHappened = true;
        }
        else
        {
            Matter = Matter + (carriedGarbageCount * smallGarbageValue);
            carriedGarbageCount = 0;
            MatterCountText.text = ("Matter Count: " + Matter);
            GUITextChange.text = ("You have " + Matter + " total.");
            GUITimer = maxTimer;
            interactionHappened = true;
        }
    }
    public void CraftingBenchUI()
    {
        menuObject.GetComponent<MenuControl>().craftMenuActive = true;
        GUIText.text = ("");
        GUIText.gameObject.SetActive(false);
    }

    public void LargeGarbageUI()
    {
        if (TPGunEquipped == false)
        {
            GUITextChange.text = ("This is too Heavy to carry.");
            GUITimer = maxTimer;
            interactionHappened = true;
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
            GUITextChange.text = ("You are carrying to much already!");
            GUITimer = maxTimer;
            interactionHappened = true;
        }        
    }
}
