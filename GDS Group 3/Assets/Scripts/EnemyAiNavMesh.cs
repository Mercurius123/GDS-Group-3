using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAiNavMesh : MonoBehaviour
{

    private NavMeshAgent Fish;

    public GameObject Player;

    public float FishDistanceRun = 4.0f;





    void Start()
    {
        Fish = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);


        if (distance < FishDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            Fish.SetDestination(newPos);

        }







    }
}
