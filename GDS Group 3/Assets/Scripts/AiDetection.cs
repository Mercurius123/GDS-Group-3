using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiDetection : MonoBehaviour
{

    public GameObject Player;
    public float speed;
    public float FishDistanceRun = 4.0f;


    void Start()
    {

    }

    void Update()
    {


        float distance = Vector3.Distance(transform.position, Player.transform.position);


        if (distance < FishDistanceRun)
        {
            transform.LookAt(Player.transform.position);
            transform.Translate(0, 0, speed * Time.deltaTime);
        }


    }

    //void OnCollisionStay(Collision obj)
    //{

    //    if(obj.gameObject.name == "Player")
    //    {
    //        speed = 0f;
    //    }
    //    else{

    //        speed = 5;
    //    }





    //}
}
