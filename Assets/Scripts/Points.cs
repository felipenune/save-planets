using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
	public static int points;
	public string color;

	public GameObject explosion;
	GameObject cameraShake;

	private void Start()
	{
		cameraShake = GameObject.FindGameObjectWithTag("CameraShake");
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("Target"))
		{
			Destroy(this.gameObject);
			points += 1;
			Placar.score = points;
		}
		else if (collision.collider.CompareTag("Planets"))
		{
			Destroy(this.gameObject);
			cameraShake.GetComponentInChildren<cameraShaker>().Shake();
			Handheld.Vibrate();
			Instantiate(explosion, transform.position, Quaternion.identity);
			Timer.chances -= 1;
		}
	}
}
