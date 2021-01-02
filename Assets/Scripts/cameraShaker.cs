using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShaker : MonoBehaviour
{
	Vector3 camPosInicial;
	public float magnitude = 0.1f, time = 0.3f;
	public Camera mainCamera;

	public void Shake()
	{
		camPosInicial = mainCamera.transform.position;
		InvokeRepeating("StartShake", 0f, 0.005f);
		Invoke("StopShake", time);
	}

	void StartShake()
	{
		float camOffsetX = Random.value * magnitude * 2 - magnitude;
		float camOffsetY = Random.value * magnitude * 2 - magnitude;
		Vector3 camPosIntermediaria = mainCamera.transform.position;
		camPosIntermediaria.x += camOffsetX;
		camPosIntermediaria.y += camOffsetY;
		mainCamera.transform.position = camPosIntermediaria;
	}

	void StopShake()
	{
		CancelInvoke("StartShake");
		mainCamera.transform.position = camPosInicial;
	}

}
