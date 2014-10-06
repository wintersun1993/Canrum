using UnityEngine;
using System.Collections;

public class Enemy_Logic : MovementClass {
	public GameObject rifle;
	public bool clicked = false;
	public int seconds = 0;
	public bool colliding = false;
	float RectWidth = Screen.width;
	float AlertRectWidth = Screen.width;
	//collision
	void OnTriggerEnter(Collider other) {
		rifle.SetActive (true);
		colliding = true;
		audio.Play();

	}
	//collision out
	void OnTriggerExit (){
		rifle.SetActive (false);
		colliding = false;
		seconds = 0;
		audio.Stop();
	}
	//onclick fight starts

	//show enemy menu
	public void OnGUI(){
		GUI.Box(new Rect(0,0,RectWidth,20), "Fuel");
		GUI.Box(new Rect(0,20,Screen.width,20), "Amo");

		if (clicked == true || colliding == true) {
			GUI.Box(new Rect(100,100,100,100), seconds.ToString());
		}
		if (colliding == true) {
			GUI.color = Color.red;
			GUI.Box(new Rect(0,40,AlertRectWidth,20), "ALERT");
		}
	}
	void Update(){
		//Fuel --
		RectWidth = RectWidth - 0.01f;



		//Hitpoints -- logic
		if (colliding == true) {
			seconds --;
			AlertRectWidth = AlertRectWidth - 3.5f;
			if (seconds == -400) {

			}

		}
		else if (colliding == false) {
			AlertRectWidth = Screen.width;
		}

		//hitpoints end logic

		//Enemy menu loogic
		if (Input.GetMouseButtonDown(1)) {
			clicked = true;
			print ("ENEMY MENU");

		}


	}


}
