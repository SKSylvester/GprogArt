using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Rigidbody2D DoorRB;
    public int KeysNeeded =5; //numbers of keys required to open the door
   
    public void CheckKeys(int keysCollected) // To verify if the player has the required keys
    {
        if (keysCollected >= KeysNeeded)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        gameObject.SetActive(false);
        Debug.Log("Door Opened");
    }
}
