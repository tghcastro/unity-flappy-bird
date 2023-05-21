using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text textScore;
    public GameObject gameOverScreen;

    void Start()
    {

    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        Debug.Log("Adding Score: " + scoreToAdd);
        playerScore = playerScore + scoreToAdd;
        textScore.text = playerScore.ToString();
    }

    public void restartGame()
    {
        Debug.Log("Restarting Game. Final Score: " + playerScore);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        Debug.Log("Activating Game Over Screen");
        gameOverScreen.SetActive(true);
    }
}
