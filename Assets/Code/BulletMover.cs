using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour
{
	public float speed;
	void Start()
	{
		rigidbody.velocity = transform.up * speed;
	}
	//Bullet Collider
	public GameObject explosion;
	

	void OnTriggerEnter(Collider other) {
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
	
}
