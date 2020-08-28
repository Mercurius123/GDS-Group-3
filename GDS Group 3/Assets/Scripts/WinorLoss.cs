using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinorLoss : MonoBehaviour
{
    public bool win = true;
    public float health;
    public float oxygen;

    private static GameObject instance;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
            instance = gameObject;
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        oxygen = GameObject.Find("Player").GetComponent<PlayerOverlord>().PlayerOxygenF;
        health = GameObject.Find("Player").GetComponent<PlayerOverlord>().PlayerHealth;

        if (oxygen < 0 || health < 0)
        {
            win = false;
        }

        if (win == false)
        {
            GameObject.Find("Death").SetActive(true);
            GameObject.Find("Victory").SetActive(false);
        }
    }
}
