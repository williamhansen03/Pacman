using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startui : MonoBehaviour
{

    public TMP_Text Highscore;

    // Start is called before the first frame update
    void Start()
    {
        Highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
}
