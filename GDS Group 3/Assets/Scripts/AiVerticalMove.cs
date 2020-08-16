using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiVerticalMove : MonoBehaviour
{
    Animator anim;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>(); // this gets the animator in the bird object
    }


    void Update()
    {


        if (Input.GetMouseButton(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000))
            {
                agent.SetDestination(hit.point);
                anim.SetBool("fall", false);
                anim.SetBool("rise", true); // this plays the animation of the birds transform flying up
            }
        }

        if (agent.remainingDistance <= float.Epsilon)// this here makes the bird land when your cubes reached its destination.
        {

            anim.SetBool("rise", false);
            anim.SetBool("fall", true); // this plays the animation of the bird landing
        }
    }
}

