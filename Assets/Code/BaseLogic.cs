using UnityEngine;
using System.Collections;

public class BaseLogic : MonoBehaviour {


	public void OnTriggerEnter(Collider other) {

		audio.Play();
		
	}
	//collision out
	void OnTriggerExit (){

		audio.Stop();
	}
}
