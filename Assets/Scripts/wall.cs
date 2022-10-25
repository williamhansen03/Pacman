using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{

    public GameObject pacman;
    public GameObject Ghost;

    private Rigidbody2D rb;

    private int random;
    

    private void Start()
    {
        rb = Ghost.GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;

        
    }

    

    private void OnTriggerStay2D(Collider2D collision)
    {
        

        if(collision.gameObject.tag == "Ghost")
        {
            if (random == 1)
            {

               

            }
            else if (random == 2)
            {
                
            }
            else if (random == 3)
            {
                
            }
            else
            {
                


            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ghost")
        {

            random = Random.Range(0, 3);
        }
    }

    /*
    private bool iswall;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iswall == false)
        {
            if (pacman.GetComponent<Player>().side == sider)
            {
                pacman.transform.rotation = Quaternion.Euler(0, 0, grader);
                
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            iswall = false;
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            iswall = true;
            
        }
    }*/


}