using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public int Respawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //checks the tag of the object it collides with
        {
            Debug.Log("Player Won.");

            

            SceneManager.LoadScene(Respawn); //Restarts the game
            Debug.Log("Scene reloaded.");
        }
    }
}
