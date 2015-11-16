using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	public float speed=3.0f;
	private ControlScript Controls;

	// Use this for initialization
	void Start () {
		Controls= GetComponent<ControlScript>();

	}
	
	// Update is called once per frame
	void Update () {
		//Move Player
		transform.Translate(Vector3.right * speed* Time.deltaTime, Space.World);
		transform.Translate(Vector3.up *Controls.MovePlayer.y * speed * Time.deltaTime, Space.World);
		if (Controls.MovePlayer.y == 0) {
			transform.Translate(Vector3.up * -speed * Time.deltaTime, Space.World);
		}
	}

}
