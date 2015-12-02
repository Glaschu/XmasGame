using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	public float speed=3.0f;

	// Update is called once per frame
	void Update () {
		//Move Player
		transform.Translate(Vector3.right * speed* Time.deltaTime, Space.World);
	}

}
