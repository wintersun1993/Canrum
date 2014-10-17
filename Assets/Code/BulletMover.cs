using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour
{
	public float speed;
	void Start()
	{
		rigidbody.velocity = transform.up * speed;
	}
	
}
