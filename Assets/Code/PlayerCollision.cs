using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{	
	public GameObject explosion;

	void OnTriggerEnter(Collider other)
	{	
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy (other.gameObject);
		PlayerVitals.HP -= 25;
	}
}


