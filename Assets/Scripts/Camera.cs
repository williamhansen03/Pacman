using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;

    private Vector3 camera;

    // Update is called once per frame
    void LateUpdate()
    {
        
        //transform.position.x = player.position.x + offset;
        camera = player.transform.position;
        transform.position = new Vector3(offset.x, camera.y, offset.z);
    }
}
