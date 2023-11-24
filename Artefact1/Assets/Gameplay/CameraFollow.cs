using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The Camera will follow the player 
    public Vector3 offset; // Be able to change the camera position to keep the player in view

    private void LateUpdate() // prevents the camera from trying to move before the player does.
    {
        transform.position = target.position + offset; // Places the camera posistion with the player and the offset allowing me to move the camera.
    }
}
