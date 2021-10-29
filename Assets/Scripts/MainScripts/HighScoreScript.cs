using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    public Text highScoreText;

    private float highScore, score;

    private void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetFloat("HighScore");
        highScoreText.text = "High Score : " + PlayerPrefs.GetFloat("HighScore", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            score = Mathf.Round(Collectibles.score);
            
            if (score > highScore)
            {
                highScoreText.text = "High Score : " + score;
                PlayerPrefs.SetFloat("HighScore", score);
            }
        }
    }
}
