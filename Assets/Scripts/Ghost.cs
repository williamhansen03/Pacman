using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;
using Unity.VisualScripting;

public class Ghost : MonoBehaviour
{

    private Rigidbody2D rb;

    private float speed = 6f;

    public int random = 0;
    int greenPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        //rb.position = new Vector3(24, 33, 0);
    }

    void FixedUpdate()
    {

        if (random == 0) // höger
        {
            rb.MovePosition(new Vector2(speed, 0) * Time.deltaTime + rb.position);

        }
        else if (random == 2) //vänster
        {
            rb.MovePosition(new Vector2(-speed, 0) * Time.deltaTime + rb.position);
        }
        else if (random == 1) // upp
        {
            rb.MovePosition(new Vector2(0, speed) * Time.deltaTime + rb.position);
        }
        else //ner
        {
            rb.MovePosition(new Vector2(0, -speed) * Time.deltaTime + rb.position);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {

            // fortsätt gå tills Ghost är mitt på point i rörelseriktningen
            // sedan slumpa ny riktning
           
            StartCoroutine(waiter(0.9f));
            

        }
        if (collision.gameObject.tag == "GreenPoint")
        {
            StartCoroutine(sec(0.7f));

        }
        if (collision.gameObject.name == "GreenPointCenter")
        {
            random = 1;
        }

        if (collision.gameObject.name == "GreenPointEnd")
        {
            StartCoroutine(sec(0.7f));

        }

        if (collision.gameObject.name == "GreenPointRight")
        {
            random = 2;
        }
    }

    IEnumerator sec(float a)
    {
        int number = Random.Range(0, 1);
        yield return new WaitForSeconds(a);
        if (greenPoint == 0)
        {
            random = 0;
            greenPoint++;
        }
        else if (number == 0)
        {
            random = 0;
        }
        else
        {
            random = 2;
        }

    }

    IEnumerator waiter(float a)
    {
        RandomFunction();
        yield return new WaitForSeconds(a);
        
        
    }

        public void RandomFunction()
    {
        int randomNumber = Random.Range(0, 2);
        randomNumber *= 2;
        randomNumber++;

        random += randomNumber;
        random = random % 4;

    }




}
