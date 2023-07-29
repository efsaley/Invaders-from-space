using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
  private bool gameStart = false;
  public void StartGame()
  {
    gameStart = true;
  }
  
  private void Update()
  {
    if (gameStart)
    {
      SceneManager.LoadScene("GameScene");
    }
  }
}

