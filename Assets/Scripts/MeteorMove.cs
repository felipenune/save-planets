using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
	public int move;
	public float rotateX, rotateY;

	float timeDestroy = 2f;

	private Rigidbody2D rb2d;

	private void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();		
	}

	private void Update()
	{
		timeDestroy -= Time.deltaTime;

		if (PauseMenu.gameIsPaused == false && GameManager.gameEnd == false)
		{
			transform.Rotate(-rotateX, -rotateY, 0f);
		}

		if (timeDestroy <= 0)
		{
			Destroy(this.gameObject);
		}
	}

	private void FixedUpdate()
	{
		rb2d.velocity = new Vector2(move, rb2d.velocity.y);
	}
}
