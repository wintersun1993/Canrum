using UnityEngine;
using System.Collections;

public class MovementClass : MonoBehaviour
{   
    private float rotationSpeed;
 	public int seconds;
	public bool colliding;
	public float speed; 
    
	public Vector3 target;
	public Transform Target;
	public Quaternion _lookRotation;
    public Vector3 _direction;
	
	float RectWidth = Screen.width;
	float AlertRectWidth = Screen.width;

	public void Start ()
	{		
		rotationSpeed = 5.0f;
		seconds = 0;
		colliding = false;
		speed = 6.0f; 
		target = transform.position;
	}
	
	public void OnGUI()
	{
		if (colliding == true)
		{
			GUI.color = Color.red;
			GUI.Box(new Rect(0, 60, AlertRectWidth, 20), "ALERT");
		}
		
		GUI.color = Color.red;
		GUI.Box(new Rect(Screen.width-150,Screen.height-120,100,30), "HP : " + PlayerVitals.HP);

		GUI.color = Color.yellow;
		GUI.Box(new Rect(Screen.width-150,Screen.height-90,100,30), "Exp : " + PlayerVitals.Experience);

		GUI.color = Color.green;
		GUI.Box(new Rect(Screen.width-150,Screen.height-60,100,30), "Level : " + PlayerVitals.Level);
	}

	void Update () 
	{
		RectWidth = RectWidth - 0.01f;
		if (colliding == true)
		{
			seconds--;
			AlertRectWidth = AlertRectWidth - 6f;
			if (seconds == -250)
			{
				
			}
		}
		else if (colliding == false)
		{
			AlertRectWidth = Screen.width;
		}

		if (Input.GetMouseButton(0) || Input.GetMouseButton(1)) 
		{
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.y = transform.position.y;
			_direction = (target-(Target.position)).normalized;
			_lookRotation = Quaternion.LookRotation(_direction);
		}

		transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * rotationSpeed);
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x,-55.0f, 50.0f), 
				0.0f, 
				Mathf.Clamp (rigidbody.position.z, -40.0f, 16.0f)
				);
	}  	
}





