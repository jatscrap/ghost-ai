using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatCherry : MonoBehaviour
{
    GameObject Cherry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) //when ghost collides with player
    {
      if (other.gameObject.name == "Cherry") //if you collide with a cherry
      {
        float x = 0.5347977f; //f makes it a float
        float y = 5.744013f;
        float z = -11.6f;
        transform.position = new Vector3(x, y, z); //set position to starting
      }
    }
}
