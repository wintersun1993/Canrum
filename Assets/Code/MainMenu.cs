using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public bool isQuit=false;

	void OnMouseEnter()
	{
		renderer.material.color = Color.gray;
	}

	void OnMouseExit()
	{
		renderer.material.color = Color.white;
	}

	void OnMouseUp()
	{
		if (isQuit == true) 
		{
			Application.Quit ();
		} 
		else 
		{
			Application.LoadLevel("Main");
		}
	}

}
