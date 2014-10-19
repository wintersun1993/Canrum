using UnityEngine;
using System.Collections;

public class Done_WeaponController : MonoBehaviour
{   
    public float fireRate;
	public float delay;
	public GameObject shot;
	public Transform shotSpawn;
	

	void Start ()
	{
		InvokeRepeating ("Fire", delay, fireRate);
	}

	void Fire ()
	{
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		audio.Play();
	}
}
