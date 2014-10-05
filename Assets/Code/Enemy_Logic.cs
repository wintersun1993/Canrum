using UnityEngine;
using System.Collections;

public class Enemy_Logic : MonoBehaviour {
	public GameObject rifle;
	void OnTriggerEnter(Collider other) {
		rifle.SetActive (true);
	}
	void OnTriggerExit (){
		rifle.SetActive (false);
	}
	//onclick fight starts

	public void OnMouseDown(){

		print ("FIGHT");
	}
	void Behaviour(){

	}

}
