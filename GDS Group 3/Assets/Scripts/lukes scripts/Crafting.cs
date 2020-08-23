using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour
{
    public GameObject Interactable;
    public int oxyTankCost = 10;
    public int breathAmountAdded; //check if overlord uses a float or a int
    public int TPGunCost = 10;
    public int healthPackCost = 10;
    public int healthPackCurrent = 0;
    public int healthPackMax = 5;
    public int healthPackMin = 0;
    public float healAmount; //check if overloard uses floats of an int
    public Text TPGunCostText;
    public GameObject gunButton;
    public Text oxyTankCostText;
    public GameObject oxyTankButton;
    public Text healthPackCostText;
    public GameObject healthButton;
    public bool oxyTankCrafted = false;
    public bool upgradedOxyTank = false;
    public bool deactivate = false;
    public bool TPGCrafted = false;
    public float matterTimer = 3;
    public float maxmatterTimer = 3;
    public Text craftingNotifications;
    public bool craftingNote = false;

    private void Start()
    {
        TPGunCostText.text = ("Cost: " + TPGunCost);
        oxyTankCostText.text = ("Cost: " + oxyTankCost);
        healthPackCostText.text = ("Cost: " + healthPackCost);
    }
    private void Update()
    {
        if (craftingNote == true)
        {
            craftingNotifications.gameObject.SetActive(true);
            matterTimer -= Time.unscaledDeltaTime;
            if (matterTimer <= 0)
            {
                craftingNotifications.text = "";
                craftingNotifications.gameObject.SetActive(false);
                craftingNote = false;
            }
        }
    }

    public void CraftOxyTank()
    {
        if (oxyTankCrafted == true)
        {
            if (oxyTankCost <= Interactable.GetComponent<Interactable>().Matter)
            {
                matterTimer = maxmatterTimer;
                Interactable.GetComponent<Interactable>().Matter = Interactable.GetComponent<Interactable>().Matter - oxyTankCost;
                oxyTankCost = 0;
                upgradedOxyTank = true;
                oxyTankButton.SetActive(false);
                oxyTankCostText.gameObject.SetActive(false);
                craftingNotifications.text = "You Crafted the Double Oxygen Tank!";
                craftingNote = true;
                //still have to change the breath stats in here
                //also change the inventory stuff
                //also activate the gameobject
            }
            else
            {
                matterTimer = maxmatterTimer;
                craftingNotifications.text = "You need more Matter to Build that.";
                craftingNote = true;
            }
        }
        else
        {
            if (oxyTankCost <= Interactable.GetComponent<Interactable>().Matter)
            {
                matterTimer = maxmatterTimer;
                Interactable.GetComponent<Interactable>().Matter = Interactable.GetComponent<Interactable>().Matter - oxyTankCost;
                Interactable.GetComponent<Interactable>().MatterCountText.text = ("Matter: " + Interactable.GetComponent<Interactable>().Matter);
                oxyTankCost = 20;
                oxyTankCrafted = true;
                oxyTankCostText.text = "Cost: " + oxyTankCost;                
                craftingNotifications.text = "You Crafted An Oxygen Tank!";
                craftingNote = true;
                //still have to change the breath stats in here
                //also change the inventory stuff
                //also activate the gameobject
            }
            else
            {
                matterTimer = maxmatterTimer;
                craftingNotifications.text = "You need more Matter to Build that.";
                craftingNote = true;
            }

        }

    }
    public void CraftHealth()
    {
        if (healthPackCurrent == healthPackMax)
        {
            matterTimer = maxmatterTimer;
            craftingNotifications.text = "You Have Max Health Items";
            craftingNote = true;
        }
        else
        {
            if (healthPackCost <= Interactable.GetComponent<Interactable>().Matter)
            {
                matterTimer = maxmatterTimer;
                Interactable.GetComponent<Interactable>().Matter = Interactable.GetComponent<Interactable>().Matter - healthPackCost;
                Interactable.GetComponent<Interactable>().MatterCountText.text = ("Matter: " + Interactable.GetComponent<Interactable>().Matter);
                healthPackCurrent = healthPackCurrent + 1;
                craftingNotifications.text = "You Crafted a Health Stim!";
                craftingNote = true;
                //change the inventory stuff
            }
            else
            {
                matterTimer = maxmatterTimer;
                craftingNotifications.text = "You need more Matter to Build that.";
                craftingNote = true;
            }
        }
    }
    public void TPGCraft()
    {
        if (TPGunCost <= Interactable.GetComponent<Interactable>().Matter)
        {
            matterTimer = maxmatterTimer;
            Interactable.GetComponent<Interactable>().Matter = Interactable.GetComponent<Interactable>().Matter - TPGunCost;
            Interactable.GetComponent<Interactable>().MatterCountText.text = ("Matter: " + Interactable.GetComponent<Interactable>().Matter);
            TPGunCost = 0;
            TPGCrafted = true;
            gunButton.SetActive(false);
            TPGunCostText.gameObject.SetActive(false);
            craftingNotifications.text = "You Crafted the Matter Teleporter!";
            craftingNote = true;
            //change the inventory stuff
            //check if can be tied to the underwater gun animations
            //also activate the gameobject
        }
        else
        {
            matterTimer = maxmatterTimer;
            craftingNotifications.text = "You need more Matter to Build that.";
            craftingNote = true;
        }
    }
}
