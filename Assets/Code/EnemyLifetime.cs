using UnityEngine;
using System.Collections;

public class EnemyLifetime : MonoBehaviour
{
	private float lifetime = 600.0f;
	
	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}