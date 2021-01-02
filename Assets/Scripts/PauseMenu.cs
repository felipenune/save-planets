using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	public static bool gameIsPaused = false;

	public GameObject[] buttons;

	public void Pause()
	{
		if (gameIsPaused == false)
		{
			Time.timeScale = 0f;
			for (int i = 0; i < buttons.Length; i++)
			{
				buttons[i].SetActive(true);
			}
			gameIsPaused = true;
		}
		else
		{
			Time.timeScale = 1f;
			for (int i = 0; i < buttons.Length; i++)
			{
				buttons[i].SetActive(false);
			}
			gameIsPaused = false;
		}
	}
}
