using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
  private bool gameRestart = false;
  public void RestartGame()

  {
    gameRestart = true;
  }
  
  private void Update()
  {
    if (gameRestart)
    {
      SceneManager.LoadScene("StartScene");
    }
  }
}
