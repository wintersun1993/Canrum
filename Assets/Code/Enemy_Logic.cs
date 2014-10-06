using UnityEngine;
using System.Collections;

public class Enemy_Logic : MonoBehaviour {
	public GameObject rifle;
	public bool clicked = false;
	public int seconds = 0;
	public bool colliding = false;

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
		if (clicked == true || colliding == true) {
			GUI.Box(new Rect(10,10,100,100), seconds.ToString());
				}
	}
	void Update(){
		//Hitpoints -- logic
		if (colliding == true) {
			seconds --;

			if (seconds == -400) {

			}

		}

		//hitpoints end logic

		//Enemy menu loogic
		if (Input.GetMouseButtonDown(1)) {
			clicked = true;
			print ("ENEMY MENU");

		}


	}


}
