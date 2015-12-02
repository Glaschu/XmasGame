using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Buttons")
		{
		}
		else if(other.gameObject.tag == "Player")
		{
			Application.LoadLevel("End");
		}
		else
		{
		Destroy (other.gameObject);
		}

	}}
