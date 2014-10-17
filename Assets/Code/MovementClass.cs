﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class MovementClass : MonoBehaviour
{
	public float speed = 7.0f;
	public Vector3 target;
	public Transform Target;
	public float RotationSpeed = 5.0f;
	public Quaternion _lookRotation;
	public Vector3 _direction;
	public Boundary boundary;
	public int seconds = 0;
	public bool colliding = false;
	float RectWidth = Screen.width;
	float AlertRectWidth = Screen.width;
	public void Start ()
	{		
		target = transform.position;
	}
	void OnTriggerEnter(Collider other) {
		//Destroy (other.gameObject);
		//rifle.SetActive(true);


	}

	public void OnGUI()
	{
		GUI.Box(new Rect(0, 0, Screen.width, 20), "Health");
		GUI.Box(new Rect(0, 20, RectWidth, 20), "Fuel");
		GUI.Box(new Rect(0, 40, Screen.width, 20), "Amo");
		GUI.Box(new Rect(0, 80, 50, 50), "Gun 1");
		GUI.Box(new Rect(0, 140, 50, 50), "Gun 2");
		GUI.Box(new Rect(0, 200, 50, 50), "Gun 3");
		
		//if (clicked == true || colliding == true) {
		//	GUI.Box(new Rect(100,100,100,100), seconds.ToString());
		//}
		if (colliding == true)
		{
			GUI.color = Color.red;
			GUI.Box(new Rect(0, 60, AlertRectWidth, 20), "ALERT");
		}
	}
	 void Update () 
	{
		RectWidth = RectWidth - 0.01f;
		if (colliding == true)
		{
			seconds--;
			AlertRectWidth = AlertRectWidth - 6f;
			//Auto start battle
			if (seconds == -250)
			{
				
			}
		}
		else if (colliding == false)
		{
			AlertRectWidth = Screen.width;
		}
		

		if (Input.GetMouseButtonDown(0)) 
		{
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.y = transform.position.y;
		}
		_direction = (target-(Target.position)).normalized;
		_lookRotation = Quaternion.LookRotation(_direction);
		transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
				);
	}  	
}

	



