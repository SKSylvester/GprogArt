using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Get the scene manager to be able to restart the scene

public class KillPlayer : MonoBehaviour
{
    private Rigidbody2D Killrb;
    public int Respawn;

    // Start is called before the first frame update
    void Start()
    {
        Killrb = GetComponent<Rigidbody2D>(); //Get the triangle RigidBody
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Player")) //checks the tag of the object it collides with
        {
            Debug.Log("Player collided with something.");


            SceneManager.LoadScene(Respawn); //Restarts the game
            Debug.Log("Scene reloaded.");
        }
    }
}
