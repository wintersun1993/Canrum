using UnityEngine;
using System.Collections;

public class EnemyLifetime : MonoBehaviour
{
	private float lifetime;
	
	void Start ()
	{
		lifetime = 600.0f;
		Destroy (gameObject, lifetime);
	}
}