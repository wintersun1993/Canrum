using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{   
    public static float spawnWait;

	public float startWait;
	public float waveWait;

	public GameObject enemy;
	public Vector3 spawnValues;
	public int enemyCount;

	public static float SpawnWait
	{
		get
		{
			return spawnWait;
		}
		set
		{
			spawnWait=value;
		}
	}

	
	void Start ()
	{	
		spawnWait = 3;
		startWait = 1;
		waveWait = 1;
		enemyCount = 30;
		StartCoroutine (SpawnWaves ());
	}
	
	IEnumerator SpawnWaves ()
	{	
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < enemyCount; i++)
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (enemy, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
	
}
