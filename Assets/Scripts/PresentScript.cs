using UnityEngine;
using System.Collections;

public class PresentScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * 1.5f* Time.deltaTime, Space.World);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "House")
		{
			GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreScript>().presentScore++;
			Destroy(this.gameObject);
			Debug.Log("ROCK DAT SCOOTAH");
		}
		if(col.gameObject.tag == "Sky")
		{
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "House")
		{
			Destroy(this.gameObject);
		}
	}


}
