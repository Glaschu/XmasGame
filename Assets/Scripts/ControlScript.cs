using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {
	//public Vector2 MovePlayer = new Vector2();
	public float upForce = 5.0f;
	public float downForce = 3.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.W))
		{
			MoveUp();
		}
		else
		{
			MoveDown();
		}
	}

	public void MoveUp()
	{
		transform.Translate(Vector2.up * Time.deltaTime * upForce);
	}

	public void MoveDown()
	{
		transform.Translate(-Vector2.up * Time.deltaTime * downForce);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "House")
		{
			Application.LoadLevel("End");
		}
		if(col.gameObject.tag == "SkyObject")
		{
			Application.LoadLevel("End");
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "House")
		{
			Application.LoadLevel("End");
		}
		if(col.gameObject.tag == "SkyObject")
		{
			Application.LoadLevel("End");
		}
	}
}