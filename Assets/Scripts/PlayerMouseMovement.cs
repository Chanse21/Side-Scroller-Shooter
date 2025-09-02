using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        //Get mouse world position
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;

        //Move towards the mouse position
        Vector2 moveTo = Vector2.Lerp(rb.position, mouseWorldPos, moveSpeed * Time.fixedDeltaTime);

        //Add constant forward (right) movement
        float forwardSpeed = 10f; //Change this to whatever speed you want
        Vector2 forwardMove = new Vector2(forwardSpeed * Time.fixedDeltaTime, 0f);

        //Combine both
        Vector2 finalMove = moveTo + forwardMove;
        
        //Aplly movement
        rb.MovePosition(finalMove);
        //transform.position = mouseWorldPos;
    }
}
