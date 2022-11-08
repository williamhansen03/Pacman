using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side : MonoBehaviour
{
    public bool RighitWall;

    public Transform right;
    public Transform left;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "pacman")
        {
            if (RighitWall == true)
            {
                collision.gameObject.transform.position = left.position + offset;
                
            }
            if (RighitWall == false)
            {
                collision.gameObject.transform.position = right.position + offset;
                
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ghost")
        {
            if (RighitWall == true)
            {
                collision.gameObject.transform.position = left.position + offset;

            }
            if (RighitWall == false)
            {
                collision.gameObject.transform.position = right.position + offset;

            }
        }

    }
}
