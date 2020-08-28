using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encyclopedia : MonoBehaviour
{
    public GameObject Mantaray;
    public GameObject Napoleon;
    public GameObject Sunfish;
    public GameObject Tuna;
    public GameObject Clownfish;
    public GameObject Tang;
    public GameObject Stonefish;
    public GameObject Barracuda;
    public GameObject Shark;
    public GameObject Mandarinfish;

    public GameObject Floraintro;
    public GameObject Garbage;
    // Start is called before the first frame update
    void Start()
    {
        Mantaray.SetActive(true);
        Napoleon.SetActive(false);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(false);
        Clownfish.SetActive(false);
        Tang.SetActive(false);
        Stonefish.SetActive(false);
        Barracuda.SetActive(false);
        Shark.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Manta()
    {
        Mantaray.SetActive(true);
        Napoleon.SetActive(false);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(false);
        Clownfish.SetActive(false);
        Tang.SetActive(false);
        Stonefish.SetActive(false);
        Barracuda.SetActive(false);
        Shark.SetActive(false);
    }
    public void humphead()
    {
        Mantaray.SetActive(false);
        Napoleon.SetActive(true);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(false);
        Clownfish.SetActive(false);
        Tang.SetActive(false);
        Stonefish.SetActive(false);
        Barracuda.SetActive(false);
        Shark.SetActive(false);
    }
    public void Mola()
    {
        Mantaray.SetActive(false);
        Napoleon.SetActive(false);
        Sunfish.SetActive(true);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(false);
        Clownfish.SetActive(false);
        Tang.SetActive(false);
        Stonefish.SetActive(false);
        Barracuda.SetActive(false);
        Shark.SetActive(false);
    }
    public void Tunny()
    {
        Mantaray.SetActive(false);
        Napoleon.SetActive(false);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(true);
        Clownfish.SetActive(false);
        Tang.SetActive(false);
        Stonefish.SetActive(false);
        Barracuda.SetActive(false);
        Shark.SetActive(false);
    }
    public void Mandarin()
    {
        Mantaray.SetActive(false);
        Napoleon.SetActive(false);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(true);
        Tuna.SetActive(false);
        Clownfish.SetActive(false);
        Tang.SetActive(false);
        Stonefish.SetActive(false);
        Barracuda.SetActive(false);
        Shark.SetActive(false);
    }
    public void Anemonefish()
    {
        Mantaray.SetActive(false);
        Napoleon.SetActive(false);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(false);
        Clownfish.SetActive(true);
        Tang.SetActive(false);
        Stonefish.SetActive(false);
        Barracuda.SetActive(false);
        Shark.SetActive(false);
    }
    public void Yellow()
    {
        Mantaray.SetActive(false);
        Napoleon.SetActive(false);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(false);
        Clownfish.SetActive(false);
        Tang.SetActive(true);
        Stonefish.SetActive(false);
        Barracuda.SetActive(false);
        Shark.SetActive(false);
    }
    public void Stone()
    {
        Mantaray.SetActive(false);
        Napoleon.SetActive(false);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(false);
        Clownfish.SetActive(false);
        Tang.SetActive(false);
        Stonefish.SetActive(true);
        Barracuda.SetActive(false);
        Shark.SetActive(false);
    }
    public void barracuda()
    {
        Mantaray.SetActive(false);
        Napoleon.SetActive(false);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(false);
        Clownfish.SetActive(false);
        Tang.SetActive(false);
        Stonefish.SetActive(false);
        Barracuda.SetActive(true);
        Shark.SetActive(false);
    }
    public void Greatwhite()
    {
        Mantaray.SetActive(false);
        Napoleon.SetActive(false);
        Sunfish.SetActive(false);
        Mandarinfish.SetActive(false);
        Tuna.SetActive(false);
        Clownfish.SetActive(false);
        Tang.SetActive(false);
        Stonefish.SetActive(false);
        Barracuda.SetActive(false);
        Shark.SetActive(true);
    }
}
