using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            scoreText.text = "Score : " + Mathf.Round(Collectibles.score);
        }
        else
        {
            Destroy(scoreText);
        }
    }
}
