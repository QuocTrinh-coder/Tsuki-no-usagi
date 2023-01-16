using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tracking : MonoBehaviour
{
    public static tracking instance;
    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text =  "Carrots : " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint() {
        score += 1;
        scoreText.text =  "Carrots : " + score.ToString();
        if(highscore < score){
        PlayerPrefs.SetInt("highscore", score);
        }
    }
}
