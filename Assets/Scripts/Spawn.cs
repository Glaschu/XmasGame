using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{

	public GameObject[] Houses = new GameObject[4];

	public float time;
	float _time;
	public float minSpawnTime, maxSpawnTime;

	float minX, maxX;

	void Awake()
	{
//		minX = SpawnPoint.GetComponent<BoxCollider2D>().bounds.min.x;
//		maxX = SpawnPoint.GetComponent<BoxCollider2D>().bounds.max.x;
		_time = time;
		SpawnBlock(transform.position.x, Random.Range(0,4));
	}

	void Update()
	{
		time -= Time.deltaTime;

		if(time < 0)
		{
			SpawnBlock(transform.position.x, Random.Range(0,4));
			time = setRandomSpawnTime(minSpawnTime, maxSpawnTime);
		}
	}

	void SpawnBlock(float pos, int houseNo)
	{
		GameObject block = Instantiate(Houses[houseNo], new Vector3(pos, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
	}

	float GetRandomPos(float minx, float maxx)
	{
		return Random.Range(minx, maxx);
	}

	float setRandomSpawnTime(float max, float min)
	{
		return Random.Range(min, max);
	}

	

}
