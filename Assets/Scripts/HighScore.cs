using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour
{
	public Text highScore;

    void Start()
    {
		highScore.text = ("Hi-Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString());
    }

    void Update()
    {
		if (Placar.score > PlayerPrefs.GetInt("HighScore", 0))
		{
			PlayerPrefs.SetInt("HighScore", Placar.score);
			highScore.text = ("Hi-Score: " + Placar.score.ToString());
		}
		
    }
}
