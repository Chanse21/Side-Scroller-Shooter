using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayermovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 5f;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {   //Calculate horizontal movement. You can replace this with input or other logic.
        float horizontalInput = 10f; // Move right. Change to -1f for left, or use INput.GetAxis("Horizontal") for player input.

        //Create a new velocity vector.
        Vector2 newVelocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        //Apply the new velocity to the Rigidbody.
        rb.velocity = newVelocity;
    }
}          
