using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreScript : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    public static int score = 0;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>(); 
    }

   
    void Update()
    {
        scoreText.text = score.ToString(); 
        if(PlayerPrefs.GetInt("Best")<score)
        {
            PlayerPrefs.SetInt("Best", score);
        }
    }
}
