using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {
    public GameObject next;
    public bool isStart = false;
   void Awake()
    {
        if(!next)
        {
            print("Waypoint is not connected");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
    }

}
