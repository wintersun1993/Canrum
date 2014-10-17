using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
		
	public GameObject bullet;
	public Transform bulletSpawn;
	public float fireRate;
	private float nextFire;

	void Update()
	{
		//Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
		if (Input.GetButton ("Fire2") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			//GameObject clone = 
			Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation); //as GameObject;
		}
	}

}





