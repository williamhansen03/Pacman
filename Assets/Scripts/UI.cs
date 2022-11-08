using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{

    public TMP_Text text;
    public TMP_Text Highscore;

    public GameObject pacman;

    private bool w = true;

    public int s;


    // Start is called before the first frame update
    void Start()
    {
        Highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
            s = pacman.GetComponent<Player>().score;
            text.text = "" + s;


            if (w == true)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Time.timeScale = 0;
                    w = false;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Time.timeScale = 1;
                    w = true;
                }
            }

            PlayerPrefs.GetInt("HighScore", s);

            if (s > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", s);
                Highscore.text = s.ToString();
            }
        
    }


}
