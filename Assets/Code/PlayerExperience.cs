using UnityEngine;
using System.Collections;

public class PlayerExperience : MonoBehaviour
{
	public static int level=0;
	public static int experience=0;

	public static int Experience {
		get
		{
			return experience;
		}
		set
		{
			experience=value;
		}
	}

	public static int Level {
		get
		{
			return level;
		}
		set
		{
			level=value;
		}
	}

	public void Start()
	{

	}

	void Update()
	{
		if (experience == 100) 
		{
			level=1;
		}
	}
}
