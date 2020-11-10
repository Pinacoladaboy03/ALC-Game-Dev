﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -15;

    void Update()
    {
    // if an object goes past a players view in the game, remove that object
     if (transform.position.z > topBound)
     {
            Destroy(gameObject);
     }
     else if (transform.position.z < lowerBound)
     {
            Debug.Log("Game Over!");
      Destroy(gameObject);
     }
    }
}
