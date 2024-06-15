using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreDisplay;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreDisplay.text = score.ToString();
    }
}
