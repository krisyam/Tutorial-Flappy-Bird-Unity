using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreDisplay;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void AddScore (int scoreToAdd)
    {
        Debug.Log("Added score");
        score += scoreToAdd;
        scoreDisplay.text = score.ToString();
    }
    public void ResetGame ()
    {
        SceneManager.LoadScene("Game Scene");
    }
    public void GoToTitle()
    {
        SceneManager.LoadScene("Title Scene");
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
