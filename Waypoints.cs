using UnityEngine;
using UnityEngine.AI;


public class Waypoints : MonoBehaviour
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
        
        // incrementing waypoint value
        if (distance <= 2)
        {
            cur_loc += 1;
        }

        // stop script
        if (cur_loc >= Waypoint.Length)
        {
            
        }

        
        //Movement
        if (cur_loc == 0)
        {
            nm.SetDestination(Waypoint[0].position);
        }
    
        if (cur_loc == 1)
        {
            nm.SetDestination(Waypoint[1].position);
        }

        if (cur_loc == 2)
        {
            nm.SetDestination(Waypoint[2].position);
        }

        if (cur_loc == 3)
        {
            nm.SetDestination(Waypoint[3].position);
        }
    }
}