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

    public Text LevelNo;
    public GameObject Upgrade11;
    public GameObject Upgrade12;
    public GameObject Upgrade13;
    public GameObject Upgrade14;
    public GameObject Upgrade21;
    public GameObject Upgrade22;
    public GameObject Upgrade23;
    public GameObject Upgrade24;
    public GameObject Upgrade25;

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
        UpgradeSystem();
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

    public void UpgradeSystem()
    {
        if (LevelNo.text == 2.ToString())
        {
            PlayerStaminaF = 120;
            Upgrade11.SetActive(true);
            if (Input.GetKey(KeyCode.LeftShift) && PlayerStaminaF > 0)
            {
                //movespeed = 8f;
                PlayerStaminaF -= StaminaDrain * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                isRunning = true;
            }
            if (isRunning == false && PlayerStaminaF < 120)
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
            Destroy(Upgrade11, 5.0f);
        }
        if (LevelNo.text == 3.ToString())
        {
            PlayerOxygenF = 130;
            Upgrade21.SetActive(true);
            if (isInAir == true && PlayerOxygenF < 130)
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
            Destroy(Upgrade21, 5.0f);
        }
        if (LevelNo.text == 4.ToString())
        {
            PlayerOxygenF = 180;
            Upgrade22.SetActive(true);
            if (isInAir == true && PlayerOxygenF < 180)
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
            Destroy(Upgrade22, 5.0f);
        }
        if (LevelNo.text == 5.ToString())
        {
            PlayerStaminaF = 150;
            Upgrade12.SetActive(true);
            if (Input.GetKey(KeyCode.LeftShift) && PlayerStaminaF > 0)
            {
                //movespeed = 8f;
                PlayerStaminaF -= StaminaDrain * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                isRunning = true;
            }
            if (isRunning == false && PlayerStaminaF < 150)
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
            Destroy(Upgrade12, 5.0f);
        }
        if (LevelNo.text == 6.ToString())
        {
            PlayerOxygenF = 210;
            Upgrade23.SetActive(true);
            if (isInAir == true && PlayerOxygenF < 210)
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
            Destroy(Upgrade23, 5.0f);
        }
        if (LevelNo.text == 7.ToString())
        {
            PlayerOxygenF = 240;
            Upgrade24.SetActive(true);
            if (isInAir == true && PlayerOxygenF < 240)
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
            Destroy(Upgrade24, 5.0f);
        }
        if (LevelNo.text == 8.ToString())
        {
            PlayerStaminaF = 210;
            Upgrade13.SetActive(true);
            if (Input.GetKey(KeyCode.LeftShift) && PlayerStaminaF > 0)
            {
                //movespeed = 8f;
                PlayerStaminaF -= StaminaDrain * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                isRunning = true;
            }
            if (isRunning == false && PlayerStaminaF < 210)
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
            Destroy(Upgrade13, 5.0f);
        }
        if (LevelNo.text == 9.ToString())
        {
            PlayerStaminaF = 250;
            Upgrade14.SetActive(true);
            if (Input.GetKey(KeyCode.LeftShift) && PlayerStaminaF > 0)
            {
                //movespeed = 8f;
                PlayerStaminaF -= StaminaDrain * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                isRunning = true;
            }
            if (isRunning == false && PlayerStaminaF < 250)
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
            Destroy(Upgrade14, 5.0f);
        }
        if (LevelNo.text == 10.ToString())
        {
            PlayerOxygenF = 300;
            Upgrade25.SetActive(true);
            if (isInAir == true && PlayerOxygenF < 300)
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
            Destroy(Upgrade25, 5.0f);
        }
    }
}
