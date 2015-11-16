using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {
	public Vector2 MovePlayer = new Vector2();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			//Move Player Left
			if (Input.GetKey ("w")) 
			{
				MovePlayer.y = 1;
			} 
			//Move Plater Right
			else if (Input.GetKey ("s")) 
			{
				MovePlayer.y=-1;
			} 
		//Keep Player Stationary When No Movement Controls Are Detected
		else 
		{
			MovePlayer.y=0;
		}

		//Move Player Left
		if (Input.GetKeyUp ("x")) 
		{
			MovePlayer.x = 1;
		} 
		//Move Plater Right
		else
		{
			MovePlayer.x=0;
		} 
	}}