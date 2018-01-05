using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl : MonoBehaviour {
    public Text scoreText, highScoreText, gameOverText;
    public Text restartButton, exitButton;
    int playerScore = 0;
    int highScore = 0;
    public float speed = -2f;

    void Start(){
        highScore = PlayerPrefs.GetInt("Highscore", 0);
    }

    void Update()
    {
        if (playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("Highscore", highScore);
        }
        highScoreText.text = highScore.ToString();
    }

    public void AddScore(){
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void PlayerDied(){
        gameOverText.enabled = true;
        restartButton.enabled = true;
        exitButton.enabled = true;
        Time.timeScale = 0; //Freezes the game
    }

    public void Restart(){
        Application.LoadLevel(1);
        Time.timeScale = 1;
        restartButton.enabled = false;
        exitButton.enabled = false;
        //gameOverText.enabled = false;
    }

    public void Exit(){
        Application.Quit();
    }

    public void FixedUpdate(){
        if (speed > -10f){
            speed -= Time.deltaTime/15;
        }
    }
}
