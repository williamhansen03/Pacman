using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircle : MonoBehaviour
{
    public GameObject Circle;

    public GameObject pacman;

    // Start is called before the first frame update
    void Start()
    {
        spawn();

        
    }

    public void spawn()
    {
        for (int y = 0; y < 61; y+=3)
        {
            for (int i = 0; i < 55; i+=3)
            {
                //pacman.GetComponent<Player>().circle += 1;
                Instantiate(Circle, new Vector2(i, y), Quaternion.identity);
            }

        }
        
    }

}
