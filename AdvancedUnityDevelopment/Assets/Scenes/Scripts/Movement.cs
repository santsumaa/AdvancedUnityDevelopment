using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementspeed = 10;
    public float jumpforce = 200;

    private Vector2 movement = new Vector2(1, 1);

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");


        movement = new Vector2(movementspeed * inputX, rb.velocity.y);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector2.up * jumpforce);
        }

    }
    void FixedUpdate()
    {
        
        rb.velocity = movement;
        

    }
}


