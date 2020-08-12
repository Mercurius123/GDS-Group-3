using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldBorder : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform RespawnPoint;
    public Text WorldBorderText;
    public GameObject WorldText;
    float currentTime = 0f;
    float startingTime = 15f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        WorldText.SetActive(true);
        currentTime -= 1 * Time.deltaTime;
        WorldBorderText.text = "WARNING! TWO MASSIVE WHIRLPOOLS SURROUND THE AREA YOU ARE COLLECTING GARBAGE IN. YOU WILL DIE WITHIN " + currentTime.ToString() + " SECONDS UNLESS YOU RETURN TO YOUR DESIGNATED AREA!";
        if (currentTime <= 0)
        {
            WorldText.SetActive(false);
            Player.transform.position = RespawnPoint.transform.position;
        }
    }
}
