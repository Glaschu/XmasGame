using UnityEngine;
using System.Collections;

public class SkySpawner : MonoBehaviour {

	public GameObject[] Objects = new GameObject[2];
	
	public float time;
	float _time;
	
	float minY, maxY;
	
	void Awake()
	{
				minY = this.gameObject.GetComponent<BoxCollider2D>().bounds.min.y;
				maxY = this.gameObject.GetComponent<BoxCollider2D>().bounds.max.y;
		_time = time;
		SpawnBlock(GetRandomPos(minY, maxY), Random.Range(0,2));
	}
	
	void Update()
	{
		time -= Time.deltaTime;
		
		if(time < 0)
		{
			SpawnBlock(GetRandomPos(minY, maxY), 0);
			time = setRandomSpawnTime(1.5f, 3.0f);
		}
	}
	
	void SpawnBlock(float pos, int houseNo)
	{
		GameObject block = Instantiate(Objects[0], new Vector3(transform.position.x, pos, transform.position.z), Quaternion.identity) as GameObject;
	}
	
	float GetRandomPos(float miny, float maxy)
	{
		return Random.Range(miny, maxy);
	}
	
	float setRandomSpawnTime(float max, float min)
	{
		return Random.Range(min, max);
	}
}
