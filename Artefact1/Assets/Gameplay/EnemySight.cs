using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySight : MonoBehaviour
{
    private Rigidbody2D Enemyrb;
    private float rotationSpeed = 25f; // Rotate the object around the z-axis 25 degress per second

    // Start is called before the first frame update
    void Start()
    {
        Enemyrb = GetComponent<Rigidbody2D>();// Get the enemy RigidBody 
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0f, 0f, rotationSpeed * Time.deltaTime); //  Will rotate the object around at the rate of the rotationSpeed
    }
}
