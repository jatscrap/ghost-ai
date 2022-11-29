using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FSM : MonoBehaviour
{
    enum GhostState 
    {
        WANDERING,
        FOUND_PLAYER,
    };
        GameObject Player;
        GhostState state = GhostState.WANDERING;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent Ghost = GetComponent<NavMeshAgent> ();
        
        if (state == GhostState.WANDERING)
        {
                if (Ghost.remainingDistance <= 1.0f) //if the ghost is closer than 1.0f to destination
                {
                    float x = Random.Range(-20.0f, 20.0f); //set random x value
                    float z = Random.Range(-20.0f, 20.0f); //set random z value
         
                    Ghost.destination = new Vector3(x, 0.0f, z); //destination of ghost with random x and z value
                }       
        }
        
        else if(state == GhostState.FOUND_PLAYER)
        {
            Ghost.destination = Player.transform.position;
        }

    }

    void OnTriggerEnter(Collider other) //when ghost collides with player
    {
      if (other.gameObject.name == "Player")
      {
        state = GhostState.FOUND_PLAYER; //change ghost's state to found player
        Player = other.gameObject;
      }
    }
}
