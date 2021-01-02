using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
	public void Awake()
	{
		Time.timeScale = 1f;
		Timer.chances = 3;
		Placar.score = 0;
		Points.points = 0;
		PauseMenu.gameIsPaused = false;
		GameManager.gameEnd = false;
	}
	public void GameStart()
	{
		SceneManager.LoadScene(1);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
