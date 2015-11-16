using UnityEngine;
using System.Collections;

public class CameraMoveScript : MonoBehaviour {
	public Transform Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Player.position.x + 2, 5, -10);
	}
}
