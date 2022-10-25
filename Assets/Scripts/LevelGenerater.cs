using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerater : MonoBehaviour
{
    public Texture2D image;

    public GameObject cube;

    public GameObject greenPoints;
    public GameObject point;
    public GameObject Ghost;

    private int mengde = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < image.width; x++)
        {
            for (int y = 0; y < image.height; y++)
            {
                if (image.GetPixel(x, y) == Color.black)
                {
                    mengde++;
                    Instantiate(cube, new Vector2(x, y), Quaternion.identity);
                }
                
                if (image.GetPixel(x,y) == Color.red)
                {
                    Instantiate(point, new Vector2(x, y), Quaternion.identity);
                }
                /*
                if(image.GetPixel(x,y) == Color.green)
                {
                    Instantiate(greenPoints, new Vector2(x, y), Quaternion.identity);
                }*/
            }
        }
        Debug.Log(mengde);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
