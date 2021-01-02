using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	Rigidbody2D rb;
	public Vector2 startPos, endPos, direction;
	public bool ativo = true;

	float force = 500f;

	public void Awake()
	{
		ativo = true;
	}

	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
		//Primeiro if para corrigir bug que contava um touch qnd saia do pause.
		if (PauseMenu.gameIsPaused == false)
		{
			ativo = true;
		}

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && ativo == true )
		{
			startPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			endPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
		}

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && ativo == true 
			&& Time.timeScale != 0 && rb.velocity.magnitude <= 0)
		{
			endPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			direction = endPos - startPos;
			if (direction.y > 0)
			{
				rb.AddForce(direction.normalized * force);
			}			
			ativo = false;
		}

		transform.up = direction.normalized;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("hitbox"))
		{
			rb.velocity = new Vector2(0f, 0f);
			direction = new Vector2(direction.x*-1, direction.y);
			rb.AddForce(direction.normalized * force);
		}
	}
}
