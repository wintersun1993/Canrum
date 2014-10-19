using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMovement : MonoBehaviour {
	public float speed;
	public Transform Player;
	private float MinDist=0.0f;
	
	
	void Start()
	{
		Player = GameObject.FindWithTag ("Player").transform;
	}
	
	void Update()
	{
		transform.LookAt(Player);
		
		if(Vector3.Distance(transform.position,Player.position) >= MinDist){
			
			transform.position -= transform.forward*speed*Time.deltaTime;
			
		}
	}
}