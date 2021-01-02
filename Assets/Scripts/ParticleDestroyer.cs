using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour
{
	ParticleSystem particle;

    void Start()
    {
		particle = GetComponentInChildren<ParticleSystem>();
    }

    
    void Update()
    {
		if (particle)
		{
			if (!particle.IsAlive())
			{
				Destroy(this.gameObject);
			}
		}		
    }
}
