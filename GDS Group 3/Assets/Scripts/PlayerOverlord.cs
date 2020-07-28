using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerOverlord : MonoBehaviour
{
    public Image PlayerStaminaBar;
    public float PlayerStaminaF;

    public int PlayerHealth;
    public Image PlayerHealthBar;

    public Image PlayerOxygenBar;
    public float PlayerOxygenF;
    public bool isInAir;

    private float StaminaDrain = 4;
    private float StaminaRegain = 6;
    private float OxygenDrain = 1;
    private float OxygenRegain = 8;
    public bool isRunning;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth = 1000;
        PlayerStaminaF = 100;
        PlayerOxygenF = 100;
    }

    // Update is called once per frame
    void Update()
    {
        #region Stamina
        if (Input.GetKey(KeyCode.LeftShift) && PlayerStaminaF > 0)
        {
            //movespeed = 8f;
            PlayerStaminaF -= StaminaDrain * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
        }
        if (isRunning == false && PlayerStaminaF < 100)
        {
            PlayerStaminaF += StaminaRegain * Time.deltaTime;
        }
        if (PlayerStaminaF == 0)
        {
            //movespeed = 5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            //movespeed = 5f;
            isRunning = false;
        }
        #endregion

        #region Oxygen
        if (isInAir == true && PlayerOxygenF < 100)
        {
            PlayerOxygenF += OxygenRegain * Time.deltaTime;
        }
        if (isInAir == false && PlayerOxygenF > 0)
        {
            PlayerOxygenF -= OxygenDrain * Time.deltaTime;
        }
        if (PlayerOxygenF < 0)
        {
            SceneManager.LoadScene("End");
        }
        #endregion

        //bars
        PlayerHealthBar.fillAmount = (float)PlayerHealth / 1000;
        PlayerStaminaBar.fillAmount = PlayerStaminaF / 100;
        PlayerOxygenBar.fillAmount = (float)PlayerOxygenF / 100;
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Oxygen")
        {
            isInAir = true;
        }
    }

    private void OnTriggerExit(Collider target)
    {
        if (target.tag == "Oxygen")
        {
            isInAir = false;
        }
    }
}
