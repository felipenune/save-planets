using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static bool gameEnd = false;
	public GameObject gameOver;

    void Start()
    {
		gameOver.SetActive(false);
	}

	public void GameOver()
	{
		if (gameEnd == false)
		{
			gameEnd = true;
			Time.timeScale = 0f;
			gameOver.SetActive(true);
		}
	}

	public void Restart()
	{
		SceneManager.LoadScene(1);
		PauseMenu.gameIsPaused = false;
		gameEnd = false;
		gameOver.SetActive(false);
		Time.timeScale = 1f;
		Timer.chances = 3;
		Placar.score = 0;
		Points.points = 0;
	}

	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
