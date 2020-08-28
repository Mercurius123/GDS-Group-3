using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour
{
    public GameObject Interactable;
    public GameObject TPGun;
    public GameObject OxyTank1;
    public GameObject OxyTank2;
    public GameObject player;
    public int oxyTankCost = 10;
    public float breathAmountAdded = 200;
    public int TPGunCost = 100;
    public int healthPackCost = 10;
    public int healthPackCurrent = 0;
    public int healthPackMax = 5;
    public int healthPackMin = 0;
    public Text healthPackText;
    public int healAmount = 400;
    public Text inventoryText;
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
                player.GetComponent<PlayerOverlord>().PlayerOxygenF = player.GetComponent<PlayerOverlord>().PlayerOxygenF + 200;
                OxyTank1.SetActive(false);
                OxyTank2.SetActive(true);
                oxyTankButton.SetActive(false);
                oxyTankCostText.gameObject.SetActive(false);
                craftingNotifications.text = "You Crafted the Double Oxygen Tank!";
                craftingNote = true;
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
                player.GetComponent<PlayerOverlord>().PlayerOxygenF = player.GetComponent<PlayerOverlord>().PlayerOxygenF + 200;
                OxyTank1.SetActive(true);
                oxyTankCostText.text = "Cost: " + oxyTankCost;                
                craftingNotifications.text = "You Crafted An Oxygen Tank!";
                craftingNote = true;                
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
                healthPackText.text = (" " + healthPackCurrent + " ");
                craftingNotifications.text = "You Crafted a Health Stim!";
                craftingNote = true;
            }
            else
            {
                matterTimer = maxmatterTimer;
                craftingNotifications.text = "You need more Matter to Build that.";
                craftingNote = true;
            }
        }
    }

    public void UseHeal()
    {
        if (healthPackCurrent == 0)
        {
            
        }
        else
        {
            if (player.GetComponent<PlayerOverlord>().PlayerHealth >= (1000 - healAmount))
            {
                player.GetComponent<PlayerOverlord>().PlayerHealth = 1000;
                healthPackCurrent = healthPackCurrent - 1;
                healthPackText.text = (" " + healthPackCurrent + " ");
            }
            else
            {
                player.GetComponent<PlayerOverlord>().PlayerHealth = player.GetComponent<PlayerOverlord>().PlayerHealth + healAmount;
                healthPackCurrent = healthPackCurrent - 1;
                healthPackText.text = (" " + healthPackCurrent + " ");
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
            TPGun.SetActive(true);
            Interactable.GetComponent<Interactable>().TPGunEquipped = true;
        }
        else
        {
            matterTimer = maxmatterTimer;
            craftingNotifications.text = "You need more Matter to Build that.";
            craftingNote = true;
        }
    }
}
