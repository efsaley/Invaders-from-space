using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
	private static UIManager instance;

	public TextMeshProUGUI scoreText;
	private int score;
	public TextMeshProUGUI highscoreText;
	private int highscore;
	public TextMeshProUGUI coinsText;
	public TextMeshProUGUI waveText;
	private int wave;
	public Image[] lifeSprites;
	public Image healthBar;
	public Sprite[] healthBars;
	private Color32 active = new Color(1, 1, 1, 1);
	private Color32 inactive = new Color(1, 1, 1, 0.25f);
	public const string scoreKey = "score";
    public const string highscoreKey = "HighScore";
    private const string coinsKey = "Coins";
    private const string waveKey = "Wave";

	
	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
		highscore = PlayerPrefs.GetInt("HighScore");
        instance.highscoreText.text = instance.highscore.ToString("000,000");
	}



	public static void UpdateLives (int l)
	{
		foreach (Image i in instance.lifeSprites)
		{
			i.color = instance.inactive;
		}
		for (int i = 0; i < l; i++)
		{
			instance.lifeSprites[i].color = instance.active;
		}
	}
	public static void UpdateHealthBar (int h)
	{
		instance.healthBar.sprite = instance.healthBars[h];
		
	}
	
	public static void UpdateScore(int s)
    {
        instance.score += s;
        instance.scoreText.text = instance.score.ToString("000,000");
        if (instance.score > instance.highscore)
        {
            instance.highscore = instance.score;
            instance.highscoreText.text = instance.highscore.ToString("000,000");
            PlayerPrefs.SetInt("HighScore", instance.highscore);
        }
    }
	public static void UpdateWave()
	{
		instance.wave++;
		instance.waveText.text = instance.wave.ToString();
	}
	public static void UpdateCoins()
	{
		instance.coinsText.text = Inventory.currentCoins.ToString();
		PlayerPrefs.Save();
	}

	public static int getScore() {
		return instance.score;
	}

}
