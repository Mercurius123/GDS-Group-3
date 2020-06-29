using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{

    Transform target;
    NavMeshAgent agent;



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position); 

        if(distance > 1.5)
        {
            agent.updatePosition = true;
            agent.SetDestination(target.position);

        }
        else
        {
            agent.updatePosition = false;
        }

    }


}
