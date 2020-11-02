using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
         // Objects collide and get destroyed
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

}
