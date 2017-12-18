using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Screens : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

  //      Waypoints pls = new Waypoints;



        if (Waypoints.stopped == true)
        {
            gameObject.SetActive(true);
            
        }
        
          
            




        }
    }
