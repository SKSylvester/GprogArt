using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public int KeyCollected = 0; //public value for the current amount coins. 

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collect the keys");

        if (collision.CompareTag("Key"))
        {
            Debug.Log("Player has a key");

            KeyCollected++; //increase by 1 everytime code is true.
            {
                DoorController doorController = FindObjectOfType<DoorController>();
                if (doorController != null) //Checks how many keys the player has compared to the required
                {
                    doorController.CheckKeys();
                }
            }
            collision.gameObject.SetActive(false); //deletes the object when player collides.
            Debug.Log("Key collected! Total keys: " + KeyCollected);
            
        }
    }
}
