using UnityEngine;
using System.Collections;

public class DropScript : MonoBehaviour {
	public GameObject[] obj;
	private ControlScript Controls;
	int drop =0;
	
	// Use this for initialization
	void Start () {
		Controls= GetComponent<ControlScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Controls.MovePlayer.x > 0) {
			drop=0;
			Spawn ();
		}
	}

	void Spawn () {
		if (drop == 0) {
			drop=1;
			Instantiate (obj [Random.Range (0, 1)], new Vector3 (transform.position.x, transform.position.y - 1, 0), Quaternion.identity);
		}
	}
}
