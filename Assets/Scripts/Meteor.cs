using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
	public GameObject meteoro;
	float spawnTime;

	private void Start()
	{
		StartCoroutine(StarSpawn());
		spawnTime = Random.Range(1, 2f);
	}

	void Spawn()
	{
		Instantiate(meteoro, transform.position, Quaternion.identity);
	}

	IEnumerator StarSpawn()
	{
		while (true)
		{
			yield return new WaitForSeconds(spawnTime);
			Spawn();
			spawnTime = Random.Range(4f, 6f);
		}
	}
}
