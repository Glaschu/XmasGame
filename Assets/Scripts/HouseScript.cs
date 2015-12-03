using UnityEngine;
using System.Collections;

public class HouseScript : MonoBehaviour {
	public GameObject player;
	public bool presentHit=false;

	public float speed = 3.0f; 
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-Vector2.right * Time.deltaTime * speed);
	}
	
}
