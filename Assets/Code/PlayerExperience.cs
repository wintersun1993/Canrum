using UnityEngine;
using System.Collections;

public class PlayerExperience : MonoBehaviour
{
	public static int level = 0;
	public static int experience = 0;

	public static int Experience
	{
		get
		{
			return experience;
		}
		set
		{
			experience=value;
		}
	}

	public static int Level
	{
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
			restoreWeapons();
		}

		if (experience == 200) 
		{
			level=2;
			restoreWeapons();
		}

		if (experience == 400) 
		{
			level=3;
			restoreWeapons();
		}

		if (experience == 800) 
		{
			level=4;
			restoreWeapons();
		}

		if (experience == 1600) 
		{
			level=5;
			restoreWeapons();
		}

		if (experience == 3200) 
		{
			level=6;
			restoreWeapons();
		}

		if (experience == 6400) 
		{
			level=7;
			restoreWeapons();
		}

		if (experience == 12800)
		{
			level=8;
			restoreWeapons ();
		}
	}

	void restoreWeapons()
	{
		PlayerShooting.gun1Shots = 0;
		PlayerShooting.gun2Shots = 0;
	}
}
