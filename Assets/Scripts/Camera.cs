using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;

    private Vector3 playerCamera;

    // Update is called once per frame
    void LateUpdate()
    {


        playerCamera = player.transform.position;
        transform.position = new Vector3(offset.x, playerCamera.y, offset.z);
    }
}
