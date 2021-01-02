using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
	public int move;
	public float rotateX, rotateY;

	private Rigidbody2D rb2d;

	private void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		if (PauseMenu.gameIsPaused == false && GameManager.gameEnd == false)
		{
			transform.Rotate(-rotateX, -rotateY, 0f);
		}		
	}

	private void FixedUpdate()
	{
		rb2d.velocity = new Vector2(move, rb2d.velocity.y);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("hitbox"))
		{
			move *= -1;
		}
	}
}
