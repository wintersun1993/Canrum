using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMovement : MonoBehaviour {

	
	private float MinDist=0.0f;
	
    private float speed=-3;
	public Transform Player;
	
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