using UnityEngine;
using UnityEngine.AI;


public class Waypoints : MonoBehaviour
{

    NavMeshAgent nm;

    public Transform[] Waypoint;
    public int cur_loc;
    public float stop_distance;
    public bool stopped;

    /*      public bool stahp { get; set; }
    //      {
      //        return stopped;
        //  }

          //public void SetStopped(bool value)
         // {
        //      stopped = value;
         // }
      */
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
        //transform.LookAt(Waypoint[cur_loc]);

        if (distance <= 2)
        {
            cur_loc += 1;
        }

        if (cur_loc >= Waypoint.Length)
        {
            //     gameObject.SetActive(false);
            stopped = true;
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
    

//         public static bool stopped;

//    public static bool GetStopped()
  //  {
    //    return stopped;
    //}

//    public static void SetStopped(bool value)
  //  {
    //  stopped = true;
   //}

    //if (cur_loc == 4)
    //{
    //    nm.SetDestination(Waypoint[4].position);
    // }

}
}