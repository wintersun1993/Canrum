using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
		
	public GameObject bullet;
	public GameObject bullet2;
	public GameObject bullet3;
	public Transform bulletSpawn;
	public float fireRate;
	private float nextFire;
	public int guns = 1;

	void Update()
	{
		//Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
		if (Input.GetButton ("Fire2") && Time.time > nextFire && guns == 1) {
			nextFire = Time.time + fireRate;
			//GameObject clone = 
			Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation); //as GameObject;
		}
		if (Input.GetButton ("Fire2") && guns == 2) {
			nextFire = Time.time + fireRate;
			//GameObject clone = 
			Instantiate(bullet2, bulletSpawn.position, bulletSpawn.rotation); //as GameObject;
		}
		if (Input.GetButton ("Fire2") && Time.time > nextFire && guns == 3) {
			nextFire = Time.time + fireRate;
			//GameObject clone = 
			Instantiate(bullet3, bulletSpawn.position, bulletSpawn.rotation); //as GameObject;
		}
	}
	public void OnGUI()
	{

		//Changes the guns
		if (GUI.Button (new Rect (0, 80, 50, 50), "Gun 1")) {
			guns = 1;
		}
		
		if (GUI.Button (new Rect (0, 140, 50, 50), "Gun 2")) {
			guns = 2;
		}
		if (GUI.Button (new Rect (0, 200, 50, 50), "Gun 3")) {
			guns = 3;
		}
	}
}





