using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour
{
	public float speed;
	public GameObject explosion;

	void Start()
	{
		rigidbody.velocity = transform.up * speed;
	}

	void OnTriggerEnter(Collider other) 
	{
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy (other.gameObject);
		Destroy (gameObject);
		PlayerVitals.Experience += 10;
	}
}
