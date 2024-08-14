using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public bool isGameOver = false;
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSound;
    

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {   
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        scoreSound.Play();
    }

    public void gameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);
        
    }

    public void restartGame()
    {
        isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

}
 