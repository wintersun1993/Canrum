using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class MovementClass : MonoBehaviour
{
	public float speed = 7.0f;
	private Vector3 target;
	public Transform Target;
	public float RotationSpeed = 5.0f;
	private Quaternion _lookRotation;
	private Vector3 _direction;
	public Boundary boundary;

	public GUIText scoreText;
	private int score;

	void Start ()
	{
		score = 0;
		UpdateScore ();
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

		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
				);
	}  
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}
}

	



