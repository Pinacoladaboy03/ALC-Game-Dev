using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    public float rotationSpeed = 20;
    public float verticalInput = 20;
    
    private float forwardInput;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");

        
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * verticalInput);
    }
}
