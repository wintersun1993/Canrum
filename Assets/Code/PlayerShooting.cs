using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
		
	public GameObject bullet;
	public GameObject bullet2;
	public GameObject bullet3;
	public Transform bulletSpawn;

	public float fireRate;
	private float nextFire;

	public int gunsType = 1;

	public int gun1Shots;
	public int gun2Shots;
	public int gun3Shots;


	void Update()
	{

		//Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
		if (Input.GetButton ("Fire2") && Time.time > nextFire && gunsType == 1) {
			fireRate = 0.30f;
			nextFire = Time.time + fireRate;
			gun1Shots += 1;

			//GameObject clone = 
			Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation); //as GameObject;
		}
		if (Input.GetButton ("Fire2") && Time.time > nextFire && gunsType == 2) {
			fireRate = 0.10f;
			nextFire = Time.time + fireRate;
			gun2Shots += 1;
			if (gun2Shots == 100) {
				gunsType = 1;
			}
			else if (gunsType == 2){//GameObject clone = 
			Instantiate(bullet2, bulletSpawn.position, bulletSpawn.rotation); //as GameObject;
			}
		}
		if (Input.GetButton ("Fire2") && Time.time > nextFire && gunsType == 3) {
			fireRate = 0.50f;
			nextFire = Time.time + fireRate;
			gun3Shots += 10;
			if (gun3Shots == 100) {
				gunsType = 1;
			}
			//GameObject clone = 
			Instantiate(bullet3, bulletSpawn.position, bulletSpawn.rotation); //as GameObject;
		}
	
	}
	public void OnGUI()
	{

		//Changes the guns
		if (GUI.Button (new Rect (0, 80, 100, 50), "Rocket #")) {
			gunsType = 1;



		}
		int lazerShots = 100 - gun2Shots;
		if (GUI.Button (new Rect (0, 140, lazerShots, 50), "Lazer +" + lazerShots.ToString())) {
			gunsType = 2;

		}
		int bomberShots = 100 - gun3Shots;
		if (GUI.Button (new Rect (0, 200, bomberShots, 50), "Bomber +" + bomberShots.ToString())) {
			gunsType = 3;

		}
	}
}





