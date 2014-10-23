using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMovement : MonoBehaviour
{
	private float minDist;
	private float speed;

	public Transform Player;
	
	void Start()
	{
		minDist = 0.0f;
		speed = -3;
		Player = GameObject.FindWithTag ("Player").transform;
	}
	
	void Update()
	{
		transform.LookAt(Player);
		
		if(Vector3.Distance(transform.position,Player.position) >= minDist)
		{
			transform.position -= transform.forward*speed*Time.deltaTime;
		}
	}
}