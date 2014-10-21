using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin = -32, xMax = 22, zMin = -3, zMax = -1;
}

public class MovementClass : MonoBehaviour
{   
    public int seconds = 0;
	public bool colliding = false;
	private float speed = 6.0f; 
    private float RotationSpeed = 5.0f;
	public Vector3 target;
	public Transform Target;
	public Quaternion _lookRotation;
    public Vector3 _direction;
    public Boundary boundary;
	
	float RectWidth = Screen.width;
	float AlertRectWidth = Screen.width;
	public void Start ()
	{		
		target = transform.position;
	}
	
	public void OnGUI()
	{
		GUI.Box(new Rect(0, 0, Screen.width, 20), "Health");
		GUI.Box(new Rect(0, 20, RectWidth, 20), "Fuel");
		
		
		
		//if (clicked == true || colliding == true) {
		//	GUI.Box(new Rect(100,100,100,100), seconds.ToString());
		//}
		if (colliding == true)
		{
			GUI.color = Color.red;
			GUI.Box(new Rect(0, 60, AlertRectWidth, 20), "ALERT");
		}
	}
	void Update () 
	{
		RectWidth = RectWidth - 0.01f;
		if (colliding == true)
		{
			seconds--;
			AlertRectWidth = AlertRectWidth - 6f;
			//Auto start battle
			if (seconds == -250)
			{
				
			}
		}
		else if (colliding == false)
		{
			AlertRectWidth = Screen.width;
		}

		
		if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) 
		{
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.y = transform.position.y;
			_direction = (target-(Target.position)).normalized;
			_lookRotation = Quaternion.LookRotation(_direction);

		}
		transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

		
		rigidbody.position = new Vector3 
			(
				
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
				);
		
	}  	
}





