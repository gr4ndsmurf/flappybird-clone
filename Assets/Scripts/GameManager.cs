using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject getReady;

    public static bool gameStarted;

    public GameObject mainScoreText;

    public Sprite metalMedal, bronzeMedal, silverMedal, goldMedal;
    public Image medalImg;

    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameStarted = false;
    }

    public void GameHasStarted()
    {
        gameStarted = true;
        getReady.SetActive(false);
        mainScoreText.SetActive(true);
    }
    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        mainScoreText.SetActive(false);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        int gameScore = mainScoreText.GetComponent<Score>().score;

        if (gameScore > 0 && gameScore <= 10)
        {
            medalImg.sprite = metalMedal;
        }
        else if (gameScore > 10 && gameScore <= 20)
        {
            medalImg.sprite = bronzeMedal;
        }
        else if (gameScore > 20 && gameScore <= 30)
        {
            medalImg.sprite = silverMedal;
        }
        else if (gameScore > 30)
        {
            medalImg.sprite = goldMedal;
        }
    }
}
