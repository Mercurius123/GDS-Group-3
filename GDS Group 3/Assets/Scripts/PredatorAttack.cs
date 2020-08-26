using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorAttack : MonoBehaviour
{
    public GameObject hurtUI;
    public bool touched;

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Predator")
        {
            hurtUI.SetActive(true);
            Invoke("TurnOffHurtUI", 1f);
            //put sound effect here
            gameObject.GetComponent<PlayerOverlord>().PlayerHealth = gameObject.GetComponent<PlayerOverlord>().PlayerHealth - 50;

            touched = true;
        }
    }

    void TurnOffHurtUI()
    {
        hurtUI.SetActive(false);
    }
}
