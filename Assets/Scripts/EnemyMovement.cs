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
    private bool playerInSight = false;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        currentTarget = waypoints[currentIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && playerInSight)
        {
            navMeshAgent.SetDestination(player.position);
        } else if (Vector3.Distance(transform.position, currentTarget.position) <= 1f && !gotToCheckpoint)
        {
            gotToCheckpoint = true;
            MoveToNextWaypoint();
        } else {
            navMeshAgent.SetDestination(currentTarget.position);
            gotToCheckpoint = false;
        }
    }

    void MoveToNextWaypoint()
    {
        if (currentIndex <= waypoints.Count)
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
