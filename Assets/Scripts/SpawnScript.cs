using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public GameObject[] obj;
	public GameObject cam;
	public Vector2 spawnLoc = new Vector2();
	public float hSize=4.15f;
	//hsize should be half the pevesuse +have new house
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	// Update is called once per frame
	void Update () {
		if (cam.gameObject.transform.position.x > spawnLoc.x + hSize) {
			Spawn ();
		}
	}
	void Spawn () {
		spawnLoc = cam.gameObject.transform.position;
		Instantiate (obj[Random.Range(0,3)], transform.position, Quaternion.identity);
		
	}
}
