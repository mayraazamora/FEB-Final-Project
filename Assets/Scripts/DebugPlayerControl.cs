using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DebugPlayerControl : MonoBehaviour
{
    private NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
        // Store the nav mesh agent
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the left mouse buttton has been pressed 
        if (Input.GetMouseButtonDown(0))
        {
            // Convert the mouse screen position to a world ray
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Raycast into the world
            if(Physics.Raycast(ray, out var hit))
            {
                // If the object that was clicked is "walkable" 
                if(hit.collider.gameObject.layer == LayerMask.NameToLayer("Walkable"))
                {
                    // Set the player's destination to the point we clicked
                    navAgent.SetDestination(hit.point);
                }
            }
        }
    }
}
