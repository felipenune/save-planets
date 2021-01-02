using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalUPDown : MonoBehaviour
{
	public int move;

	private Rigidbody2D rb2d;

	private void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		transform.Rotate(0f, 1f, 0f);
	}

	private void FixedUpdate()
	{
		rb2d.velocity = new Vector2(rb2d.velocity.x, move);		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("hitbox"))
		{
			move *= -1;
		}
	}
}
