using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
<<<<<<< HEAD
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;

    void Update()
    {
             // Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
            // Player movement left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Lauch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
=======
{
public float horizontalInput;
public float speed = 10.0f;
public float xRange = 10;

    // Start is called before the first frame update
    void Start()
    {
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
    // Keep the player in bounds
        if (transform.position.x < -10-xRange) 
        {
        transform.position = new Vector3(-10-xRange, transform.position.y, transform.position.z);
>>>>>>> master
        }
    }
}
