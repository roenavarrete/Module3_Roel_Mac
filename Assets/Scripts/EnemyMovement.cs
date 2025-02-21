using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public List<Transform> waypoints;

    private int currentIndex = 1;
    private Transform currentTarget;
    private bool gotToCheckpoint = false;

    private NavMeshAgent navMeshAgent;
    private FieldOfView fieldOfView;
    private bool beingChased = false;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        fieldOfView = GetComponent<FieldOfView>();
        currentTarget = waypoints[currentIndex];
        navMeshAgent.SetDestination(currentTarget.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && fieldOfView.canSeePlayer) //Player is within alien vision
        {
            navMeshAgent.SetDestination(player.position);
            beingChased = true;
        } else if (!fieldOfView.canSeePlayer && beingChased) //Player got away
        {
            MoveToClosestWaypoint();
        } else if (Vector3.Distance(transform.position, currentTarget.position) <= 1f && !gotToCheckpoint)
        {
            gotToCheckpoint = true;
            MoveToNextWaypoint();
        } else {
            gotToCheckpoint = false;
        }
    }

    void MoveToClosestWaypoint()
    {
        gotToCheckpoint = false;
        beingChased = false;
        Transform closestWaypoint = waypoints[0];
        float minDistance = Vector3.Distance(transform.position, closestWaypoint.position);
        currentIndex = 0;

        for (int i = 1; i < waypoints.Count; i++)
        {
            Transform waypoint = waypoints[i];
            float waypointDistance = Vector3.Distance(transform.position, waypoint.position);
            if (waypointDistance < minDistance)
            {
                currentIndex = i;
                closestWaypoint = waypoint;
                minDistance = waypointDistance;
            }
        }

        currentTarget = closestWaypoint;
        navMeshAgent.SetDestination(currentTarget.position);
    }

    void MoveToNextWaypoint()
    {
        if (currentIndex < waypoints.Count - 1)
        {
            currentIndex++;
        } else
        {
            currentIndex = 0;
        }
        currentTarget = waypoints[currentIndex];
        navMeshAgent.SetDestination(currentTarget.position);
    }
}
