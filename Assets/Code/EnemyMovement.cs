using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMovement : MonoBehaviour {
	public float speed;

	
	void Start()
	{
		rigidbody.velocity = transform.forward * speed;
	}
}