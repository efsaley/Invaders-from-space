using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RestartInfo : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI scoreText;
    

    private void OnEnable()
    {
        UpdateRestartInfo();
    }

    private void UpdateRestartInfo()
    {
        
        int currentScore = UIManager.getScore();
        scoreText.text = currentScore.ToString("000,000");
        int savedHighScore = PlayerPrefs.GetInt(UIManager.highscoreKey, 0);
        highscoreText.text = savedHighScore.ToString("000,000");
    }
}