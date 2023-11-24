using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movementSpeed = 5f;
    private Vector2 movementDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody component attached to the Player
    }

    // Update is called once per frame
    void Update() // More responsive that using the void start
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); // Moves the player through input
    }

    void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed; //Allows the players velocity to move in a direction at a fixed speed.
    }
}
