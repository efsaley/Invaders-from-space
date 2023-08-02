using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RestartInfo : MonoBehaviour
{
    
    public TextMeshProUGUI highscoreText;

    private void OnEnable()
    {
        UpdateRestartInfo();
    }

    private void UpdateRestartInfo()
    {
        // High Score değerini alın
        int savedHighScore = PlayerPrefs.GetInt(UIManager.highscoreKey, 0);

        // High Score değerini ekranda göster
        highscoreText.text = savedHighScore.ToString("000,000");
    }
}