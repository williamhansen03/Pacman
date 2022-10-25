using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostWall : MonoBehaviour
{
    

    public GameObject Ghost;
    private Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = Ghost.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (gameObject.name == "Left")
            {
                rb.position = rb.position + new Vector2(0.4f, 0);
                Ghost.GetComponent<Ghost>().random = Random.Range(0,3);
                Debug.Log("Left");
            }
            else if (gameObject.name == "Right")
            {
                rb.position = rb.position + new Vector2(-0.4f, 0);
                Ghost.GetComponent<Ghost>().random = Random.Range(0, 3);
                Debug.Log("Right");
            }
            else if (gameObject.name == "Up")
            {
                rb.position = rb.position + new Vector2(0, -0.4f);
                Ghost.GetComponent<Ghost>().random = Random.Range(0, 3);
                Debug.Log("UP");
            }
            else if (gameObject.name == "Down")
            {
                rb.position = rb.position + new Vector2(0, 0.4f);
                Ghost.GetComponent<Ghost>().random = Random.Range(0, 3);
                Debug.Log("DOWN");
            }


        }
    }

}
