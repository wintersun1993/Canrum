using UnityEngine;
using System.Collections;


public class MovementClass : MonoBehaviour
{
	public float speed = 10.0f;
	private Vector3 target;
	public Transform Target;
	public float RotationSpeed = 10.0f;
	private Quaternion _lookRotation;
	private Vector3 _direction;

	void Start ()
	{
		target = transform.position;
	}
	void OnTriggerEnter(Collider other) {
		//Destroy (other.gameObject);
		//rifle.SetActive(true);


	}
	void Update () 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.y = transform.position.y;
		}
		_direction = (target-(Target.position)).normalized;
		_lookRotation = Quaternion.LookRotation(_direction);
		transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}  
}

	



