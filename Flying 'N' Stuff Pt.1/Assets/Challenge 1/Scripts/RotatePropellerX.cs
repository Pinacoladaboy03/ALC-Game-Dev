﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private float propellorSpeed = 1000;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
