using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public int KeyCollected = 0; //public value for the current amount coins. 
    public List<DoorController> doorControllers = new List<DoorController>();

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
            KeyCollected++; //Increases by 1 everytime player gets a key
            collision.gameObject.SetActive(false);
            Debug.Log("Key collected! Total keys: " + KeyCollected);
            CheckAllDoors();
        }
    }
    private void CheckAllDoors()
    {
        foreach (DoorController door in doorControllers)
        {
            door.CheckKeys(KeyCollected);
        }
    }
}
