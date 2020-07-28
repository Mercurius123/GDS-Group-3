using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinorLoss : MonoBehaviour
{
    public bool win;
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

        if (oxygen < 0)
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
