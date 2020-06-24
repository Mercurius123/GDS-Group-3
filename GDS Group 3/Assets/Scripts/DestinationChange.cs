using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationChange : MonoBehaviour
{
    public int xPos;
    public int zPos;


    void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Character")
       {
            xPos = Random.Range(11, -11);
            zPos = Random.Range(3, -10);
            this.gameObject.transform.position = new Vector3(xPos, 1.5f, zPos);

       } 
    }



}
