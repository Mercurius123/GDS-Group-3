using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flora : MonoBehaviour
{
    public GameObject Corals;
    public GameObject Seaweed;
    // Start is called before the first frame update
    void Start()
    {
        Corals.SetActive(false);
        Seaweed.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void macroalgae()
    {
        Corals.SetActive(false);
        Seaweed.SetActive(true);
    }
    public void Anthozoa()
    {
        Seaweed.SetActive(false);
        Corals.SetActive(true);
    }
}
