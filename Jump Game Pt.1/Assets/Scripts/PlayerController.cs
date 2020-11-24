using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    private Animator playerAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    public bool isOnGround = true;
    public ParticleSystem dirtParticle;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;
        playerAnim.SetTrigger("Jump_trig");
        dirtParticle.Stop();
        }
    }
    
    public bool gameOver = false;
    public ParticleSystem explosionParticle;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
        isOnGround = true; 
        dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        dirtParticle.Stop();
        {
        gameOver = true;
        Debug.Log("Game Over!");
        playerAnim.SetBool("Death_b", true);
        playerAnim.SetInteger("DeathType_int", 1); 
        explosionParticle.Play();
        }
    }
}