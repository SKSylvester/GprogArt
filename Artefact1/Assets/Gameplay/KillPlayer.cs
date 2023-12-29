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
        if (CompareTag("Player"))
        {
            Debug.Log("Player collided with something.");


            SceneManager.LoadScene(Respawn); //If the player collides with triagle in loads the scene.
            Debug.Log("Scene reloaded.");
        }
    }
}
