using UnityEngine;
using System.Collections;

public class PlayerVitals : MonoBehaviour
{
	public static int level;
	public static int experience;
	private static int hp;
	private static int counter;
	private static int hpcounter;
	public GUIText expText;
	public GUIText restartText;
	public GUIText gameOverText;

	private bool gameOver;
	private bool restart;

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

	public static int HP
	{
		get
		{
			return hp;
		}
		set
		{
			hp=value;
		}
	}

	public void Start()
	{
		level = 0;
		experience = 0;
		hp = 100;
		counter = 0;
		hpcounter = 0;
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		expText.text = "";
	}

	void Update()
	{	
		if (restart)
		{
			if(Input.GetKeyDown(KeyCode.R))
			{	
				Time.timeScale=1;
				Application.LoadLevel(Application.loadedLevel);
			}
		}
		if (experience == 100 && counter==0) 
		{
			level=1;
			restoreWeapons();
			counter++;
			EnemySpawn.SpawnWait=2.5f;
		}

		if (experience == 200 && counter==1) 
		{
			level=2;
			restoreWeapons();
			counter++;
			EnemySpawn.SpawnWait=2.0f;
		}

		if (experience == 400 && counter==2) 
		{
			level=3;
			restoreWeapons();
			counter++;
			EnemySpawn.SpawnWait=1.5f;
		}

		if (experience == 800 && counter==3) 
		{
			level=4;
			restoreWeapons();
			counter++;
		}

		if (experience == 1600 && counter==4) 
		{
			level=5;
			restoreWeapons();
			counter++;
			EnemySpawn.SpawnWait=1.0f;
		}

		if (experience == 3200 && counter==5) 
		{
			level=6;
			restoreWeapons();
			counter++;
		}

		if (experience == 6400 && counter==6) 
		{
			level=7;
			restoreWeapons();
			counter++;
		}

		if (experience == 12800 && counter==7)
		{
			level=8;
			restoreWeapons ();
			counter++;
			EnemySpawn.SpawnWait=0.2f;
		}

		if (hp == 0 && hpcounter==0)
		{	
			GameOver ();
			hpcounter++;
		}
	}

	void restoreWeapons()
	{
		PlayerShooting.gun1Shots = 0;
		PlayerShooting.gun2Shots = 0;
		hp = 100;
	}

	public void GameOver()
	{
		gameOverText.text = "Game Over";
		gameOver = true;
		restartText.text = "Press 'R' for Restart";
		restart = true;
		expText.text = "Experience: " + Experience;
		Time.timeScale = 0;
	}

}
