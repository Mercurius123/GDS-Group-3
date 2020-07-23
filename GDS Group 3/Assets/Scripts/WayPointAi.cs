using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointAi : MonoBehaviour
{

    public List<Transform> waypoints = new List<Transform>();
    private Transform targetWaypoint;
    private int targetWaypointIndex = 0;
    private float minDistance = 0.1f;
    private int LastWaypointIndex;

    private float movementSpeed = 3.0f;
    
    void Start()
    {
        targetWaypoint = waypoints[targetWaypointIndex];
    }

    
    void Update()
    {
        float movementStep = movementSpeed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, movementStep);
    }
}
