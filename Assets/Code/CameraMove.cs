using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour 
{	
	private float boundary= 50.0f;
	private float speed = 5.0f;
	private int theScreenWidth;
	private int theScreenHeight;
	public Boundary bound;

	// Use this for initialization
	void Start () 
	{
		theScreenWidth = Screen.width;
		theScreenHeight = Screen.height;
	}
	
	// Update is called once per frame
	void Update ()
	{
		float mouseVert = Input.mousePosition.x;
		float mouseHor = Input.mousePosition.z;
	
		if (Input.mousePosition.x > theScreenWidth - boundary) {
			Vector3 myVector = transform.position;
			myVector.x += 1f;
			transform.position = myVector;
		}
	
		if (Input.mousePosition.x < 0 + boundary) {
			Vector3 myVector = transform.position;
			myVector.x -= 1f;
			transform.position = myVector;
		}
	
		if (Input.mousePosition.y > theScreenHeight - boundary) {
			Vector3 myVector = transform.position;
			myVector.z += 1f;
			transform.position = myVector; 
		}
	
		if (Input.mousePosition.y < 0 + boundary) {
			Vector3 myVector = transform.position;
			myVector.z -= 1f;
			transform.position = myVector;
		}

		transform.position = new Vector3(
			Mathf.Clamp(transform.position.x, bound.xMin, bound.xMax),
			13.0f,
			Mathf.Clamp(transform.position.z, bound.zMin, bound.zMax));
	} 
}

 