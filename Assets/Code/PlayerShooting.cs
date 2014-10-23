using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
	public GameObject bullet;
	public GameObject bullet2;
	public GameObject bullet3;
	public GameObject shield;

	public Transform bulletSpawn;

	private float fireRate;
	private float nextFire;

	private int hpCurr;

	private int shieldUse;
	private int laserShot;
	private int rocketShots;

	private int gunsType;

	public static int gun1Shots;
	public static int gun2Shots;
	public static int gun3Shots;
	public static int shieldLife;

	public bool shieldActive = false;
	public GameObject explosion;

	void Start()
	{
		shieldUse=4;
		laserShot=50;
		rocketShots=100;
		gunsType = 1;
		hpCurr = PlayerVitals.HP;
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log (hpCurr);
		if (shieldActive == true && shieldLife < 5)
		{
			audio.Play();
			Destroy (other.gameObject);
			Instantiate(explosion, transform.position, transform.rotation);
			shieldLife += 1;
			PlayerVitals.Experience+=10;
			PlayerVitals.HP=hpCurr;
		}

		if (shieldLife == 5)
		{
			shieldActive = false;
			shield.SetActive(false);
			shieldLife = 0;
			gunsType = 1;
		}
	}

	void Update()
	{
		rocketShots = 100 - gun1Shots;
		laserShot = 50 - gun2Shots;
		if (Input.GetButton ("Fire2") && Time.time > nextFire && gunsType == 1)
		{
			fireRate = 0.30f;
			nextFire = Time.time + fireRate;
			gun1Shots += 1;

			if(gun1Shots == 100)
			{
				if(gun2Shots<50)
					gunsType = 2;
				else if(gun3Shots<4)
					gunsType=4;
				else
					gunsType=5;
			}
			else if(gunsType==1)
			{
				Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
			}
		}

		if (Input.GetButton ("Fire2") && Time.time > nextFire && gunsType == 2) 
		{
			fireRate = 0.10f;
			nextFire = Time.time + fireRate;
			gun2Shots += 1;

			if (gun2Shots == 50) 
			{
				if(gun1Shots<100)
					gunsType = 1;
				else if(gun3Shots<4)
					gunsType=4;
				else
					gunsType=5;
			}
			else if (gunsType == 2)
			{
				Instantiate(bullet2, bulletSpawn.position, bulletSpawn.rotation);
			}
		}
	}

	public void OnGUI()
	{	
		GUI.color = Color.cyan;
		if (rocketShots > 0)
		{
			rocketShots = 100 - gun1Shots;
			if (GUI.Button (new Rect (0, 80, 100, 50), "Rockets:" + rocketShots.ToString ()))
			{
				gunsType = 1;
			}
		}

		if(laserShot>0)
		{
			laserShot = 50 - gun2Shots;
			if (GUI.Button (new Rect (0, 140, 100, 50), "Laser:" + laserShot.ToString()))
			{
				gunsType = 2;
			}
		}

		if (shieldUse > 0 && shieldActive==false)
		{
			shieldUse = 4 - gun3Shots;

			if (GUI.Button (new Rect (0, 200, 100, 50), "Shield :" + shieldUse.ToString ()))
			{
				hpCurr=PlayerVitals.HP;
				gunsType = 4;
				shield.SetActive (true);
				shieldActive = true;
				fireRate = 1f;
				nextFire = Time.time + fireRate;
				gun3Shots += 1;

				if (gun3Shots == 4)
				{
					if(gun1Shots<100)
						gunsType = 1;
					else if(gun2Shots<50)
						gunsType=2;
					else
						gunsType=5;
				}
			}
		}
	}
}





