using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    Vector2 movement;
    public Rigidbody2D rb;
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
