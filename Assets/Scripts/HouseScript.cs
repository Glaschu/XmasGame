using UnityEngine;
using System.Collections;

public class HouseScript : MonoBehaviour {
	public GameObject player;
	public bool presentHit=false;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Player") {
			
			//Destroy (other.gameObject);
		} else if (other.tag == "Presents"){
			presentHit=true;
			//ScoreScript.presentScore++;
			Destroy (other.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			player.gameObject.GetComponent<MovementScript> ().speed = 0.0f;
		}
		if (coll.gameObject.tag == "Presents") {
			Destroy (coll.gameObject);
		}
	}
}
