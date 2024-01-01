using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Rigidbody2D DoorRB;
    public int KeysNeeded = 5; //numbers of keys required to open the door
   
    public void CheckKeys() // To verify if the player has the required keys
    {
        Debug.Log("Check keys");

        Player player = FindObjectOfType<Player>(); //Find the player and player script

        if (player != null && player.KeyCollected >= KeysNeeded) //check if keys collected are greater than or equal to 5
        {
            Debug.Log("Checking if the keys are equal too or greater than");

            OpenDoor(); //if true open the door
            Debug.Log("Open the door");
        }
    }
    private void OpenDoor() //Code for open door function
    {
        gameObject.SetActive(false); //destroy the object
        Debug.Log("Door Opened");
    }
}
