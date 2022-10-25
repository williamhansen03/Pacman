using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side : MonoBehaviour
{
    public bool RighitWall;

    public Transform right;
    public Transform left;
    public Transform pacman;
    public Transform ghost;

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
                pacman.transform.position = left.position + offset;
                
            }
            if (RighitWall == false)
            {
                pacman.transform.position = right.position + offset;
                
            }
        }

        if (collision.gameObject.name == "Ghost")
        {
            if (RighitWall == true)
            {
                ghost.transform.position = left.position + offset;

            }
            if (RighitWall == false)
            {
                ghost.transform.position = right.position + offset;

            }
        }
    }
}
