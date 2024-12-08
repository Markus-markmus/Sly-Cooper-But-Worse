using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex = 0;
    Vector3 target;
    bool isWaiting = false;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the agent has reached the target and is not waiting
        if (!isWaiting && Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    // Update the destination of the agent to the current waypoint
    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    // Iterate to the next waypoint index
    void IterateWaypointIndex()
    {
        waypointIndex++;
        // Check if the waypoint index is at every third waypoint
        if (waypointIndex % 3 == 0)
        {
            StartCoroutine(WaitAtWaypoint());
        }
        else
        {
            if (waypointIndex == waypoints.Length)
            {
                waypointIndex = 0;
            }
        }
    }

    // Coroutine to wait at the waypoint for 3 seconds
    IEnumerator WaitAtWaypoint()
    {
        isWaiting = true;
        agent.isStopped = true; // Stop the agent
        yield return new WaitForSeconds(3); // Wait for 3 seconds
        agent.isStopped = false; // Resume the agent
        isWaiting = false;

        // Check if the waypoint index exceeds the length of waypoints array
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}

