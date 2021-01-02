using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Placar : MonoBehaviour
{
	public static int score;

    void Update()
    {
		GetComponent<Text>().text = ("Score: " + score.ToString());
    }
}
