using System.Collections;
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
                Ghost.GetComponent<Ghost>().RandomFunction();
                rb.position = rb.position + new Vector2(0.2f, 0);
                
            }
            else if (gameObject.name == "Right")
            {
                Ghost.GetComponent<Ghost>().RandomFunction();

                rb.position = rb.position + new Vector2(-0.2f, 0);
                
            }
            else if (gameObject.name == "Up")
            {
                Ghost.GetComponent<Ghost>().RandomFunction();
                rb.position = rb.position + new Vector2(0, -0.2f);
                
            }
            else if (gameObject.name == "Down")
            {
                Ghost.GetComponent<Ghost>().RandomFunction();
                rb.position = rb.position + new Vector2(0, 0.2f);
                
            }


        }
    }

}
