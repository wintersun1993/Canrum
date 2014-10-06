using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
		
	public float speed;
	void Start() {

		rigidbody.velocity = transform.forward * speed;
	}

}





