using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
	public static int chances = 3;
	public GameManager gameManager;

    void Update()
    {
		GetComponent<Text>().text = ("Chances: " + chances.ToString());
		if (chances < 1)
		{
			chances = 0;
			gameManager.GetComponent<GameManager>().GameOver();
		}
    }
}