using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    Vector2 movement;
    public Rigidbody2D rb;
    public int deathCounter = 0;
    //Adding variables and references for later use 
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        //This code checks wheter or not movemnt in this case A or D is pressed each frame 
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
        //Moves the player based on input 50 times per second
        if (movement.x < 0.001f && movement.x > -0.001)
        {
            deathCounter += 1;
            print(deathCounter);
            //Checks wheter or not player is moving 
        }
        if (movement.x != 0)
        {
            deathCounter = 0;
            print(deathCounter);
            //If player is moving changes the counter back to zero 
        }
    }
}
