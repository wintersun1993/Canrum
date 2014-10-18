using UnityEngine;
using System.Collections;

public class EnemyLifetime : MonoBehaviour
{
	public float lifetime;
	
	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}