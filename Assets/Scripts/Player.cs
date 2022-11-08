using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public AudioSource pacManMunch;
    public GameObject mainCamera;
    
    private Rigidbody2D rb;
    private float speed = 15f;

    public GameObject SpawnCircle;
    public GameObject[] BigCircle;
    public GameObject ui;

    public int side = 1;

    public GameObject redGhost;
    public GameObject pinkGhost;
    public GameObject lightBlueGhost;
    public GameObject yellowGhost;

    private SpriteRenderer redSprite;
    private SpriteRenderer pinkSprite;
    private SpriteRenderer lightBlueSprite;
    private SpriteRenderer yellowSprite;

    private int ghostEaten = 0;

    private float blueTimer = 15f;

    public int score;
    private int GhostScore = 200;

    public bool BlueGhost = false;

    public int circle = 0;

    public Sprite blueGhost;

    public Sprite redGhostSprite;
    public Sprite pinkGhostSprite;
    public Sprite lightBluGhostSprite;
    public Sprite yellowGhostSprite;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;

        redSprite = redGhost.GetComponent<SpriteRenderer>();
        pinkSprite = pinkGhost.GetComponent<SpriteRenderer>();
        lightBlueSprite = lightBlueGhost.GetComponent<SpriteRenderer>();
        yellowSprite = yellowGhost.GetComponent<SpriteRenderer>();

        

    }

    // Update is called once per frame
    void Update()
    {

        


        float angleRadians = rb.rotation * Mathf.PI / 180f;
        float xSpeed = Mathf.Cos(angleRadians) * speed;
        float ySpeed = Mathf.Sin(angleRadians) * speed;
        rb.velocity = new Vector2(xSpeed, ySpeed);

        
        if (Input.GetKey(KeyCode.W))
        {
            side = 1;
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            side = 2;
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            side = 3;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            side = 4;
            
        }
        
        if (circle == 189)
        {
            SpawnCircle.GetComponent<SpawnCircle>().spawn();
            circle = 0;
            for (int i = 0; i < 5; i++)
            {
                BigCircle[i].SetActive(true);
            }
        }

        if (GhostScore > 1600)
        {
            GhostScore = 200;
        }

        if (BlueGhost == true)
        {
            
            

            if (blueTimer > 0)
            {
                blueTimer -= Time.deltaTime;
            }
            else
            {
                BlueGhost = false;
                pinkSprite.sprite = pinkGhostSprite;
                redSprite.sprite = redGhostSprite;
                lightBlueSprite.sprite = lightBluGhostSprite;
                yellowSprite.sprite = yellowGhostSprite;
            }
        }
        else
        {
            BlueGhost = false;
            pinkSprite.sprite = pinkGhostSprite;
            redSprite.sprite = redGhostSprite;
            lightBlueSprite.sprite = lightBluGhostSprite;
            yellowSprite.sprite = yellowGhostSprite;
        }

        if (ghostEaten == 4)
        {
            BlueGhost = false;
            ghostEaten = 0;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ghost")
        {
            if (BlueGhost == true)
            {
                score += GhostScore;
                GhostScore *= 2;

                ghostEaten++;

                pacManMunch.Play(0);

                if (collision.gameObject.name == "RedGhost")
                {
                    redSprite.sprite = redGhostSprite;
                    redGhost.transform.position = new Vector3(24, 33, 0);
                }
                else if (collision.gameObject.name == "PinkGhost")
                {
                    pinkSprite.sprite = pinkGhostSprite;
                    pinkGhost.transform.position = new Vector3(24, 33, 0);
                }
                else if (collision.gameObject.name == "LightBlueSprite")
                {
                    lightBlueSprite.sprite = lightBluGhostSprite;
                    lightBlueGhost.transform.position = new Vector3(24, 33, 0);
                }
                else if (collision.gameObject.name == "YellowGhost")
                {
                    yellowSprite.sprite = yellowGhostSprite;
                    yellowGhost.transform.position = new Vector3(24, 33, 0);
                }
                
            }
            else
            {
                mainCamera.GetComponent<AudioSource>().enabled = false;
                ui.SetActive(true);
                Time.timeScale = 0;

            }

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Point" || collision.gameObject.tag == "GreenPoint")
        {
            if (side == 1)
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
                side = 0;
            }

            if (side == 2)
            {
                transform.rotation = Quaternion.Euler(0, 0, 180);
                side = 0;
            }

            if (side == 3)
            {
                transform.rotation = Quaternion.Euler(0, 0, 270);
                side = 0;
            }

            if (side == 4)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                side = 0;
            }
        }

        if (collision.gameObject.tag == "Circle")
        {
            score += 10;

            Destroy(collision.gameObject);
            circle++;
            pacManMunch.Play(0);





        }
        if (collision.gameObject.tag == "BigCircle")
        {
            BlueGhost = true;

            score += 50;

            blueTimer = 15f;
            redSprite.sprite = blueGhost;
            pinkSprite.sprite = blueGhost;
            lightBlueSprite.sprite = blueGhost;
            yellowSprite.sprite = blueGhost;
            
            
            
            collision.gameObject.SetActive(false);
        }
    }

    IEnumerator waiter()
    {
        pacManMunch.Play(0);
        
        yield return new WaitForSeconds(pacManMunch.clip.length);


    }

}
