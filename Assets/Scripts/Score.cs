using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public int score;
    private TMP_Text scoreText;
    private int highScore;

    public Text PanelScoreText;
    public Text HighScoreText;
    public GameObject New;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = score.ToString();
        PanelScoreText.text = score.ToString();
        highScore = PlayerPrefs.GetInt("highscore");
        HighScoreText.text = highScore.ToString();
    }
    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();
        PanelScoreText.text = score.ToString();
        if (score > highScore)
        {
            highScore = score;
            PanelScoreText.text = highScore.ToString();
            PlayerPrefs.SetInt("highscore", highScore);
            New.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
