using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1; // time required to wait in order to fire again
    private float nextFire = 0; // amount of time until you can fire after start

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog if time limit is over
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; //Reset nextFire to current time + fireRate
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
