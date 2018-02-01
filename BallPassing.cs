using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallPassing : MonoBehaviour
{
    NavMeshAgent nm;
    public Transform[] Waypoint;
    public int cur_loc;
    public float stop_distance;

    // Use this for initialization
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        nm.stoppingDistance = stop_distance;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Waypoint[cur_loc].position);






    }
}