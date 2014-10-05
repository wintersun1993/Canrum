using UnityEngine;
using System.Collections;

public class Enemy_Logic : MonoBehaviour {
	public GameObject rifle;
	public bool clicked = false;
	void OnTriggerEnter(Collider other) {
		rifle.SetActive (true);

	}
	void OnTriggerExit (){
		rifle.SetActive (false);

	}
	//onclick fight starts

	public void OnGUI(){
		if (clicked == true) {
			GUI.Box(new Rect(10,10,100,100), "Menu");
				}
	}
	void Update(){
		if (Input.GetMouseButtonDown(1)) {
			clicked = true;
			print ("ENEMY MENU");

		}


	}


}
