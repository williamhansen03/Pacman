using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;

public class Ghost : MonoBehaviour
{

    private Rigidbody2D rb;

    private float speed = 6f;

    public int random = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        rb.position = new Vector3(24, 33, 0);
    }

    void FixedUpdate()
    {
        
        if (random == 0)
        {
            rb.MovePosition(new Vector2(speed, 0) * Time.deltaTime + rb.position);

        }
        else if (random == 1)
        {
            rb.MovePosition(new Vector2(-speed, 0) * Time.deltaTime + rb.position);
        }
        else if (random == 2)
        {
            rb.MovePosition(new Vector2(0, speed) * Time.deltaTime + rb.position);
        }
        else if (random == 3)
        {
            rb.MovePosition(new Vector2(0, -speed) * Time.deltaTime + rb.position);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            
            Debug.Log(collision.gameObject.name);
            random = Random.Range(0, 3);
            Debug.Log(random);

        }
    }




}
