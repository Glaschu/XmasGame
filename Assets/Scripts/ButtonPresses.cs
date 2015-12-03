using UnityEngine;
using System.Collections;

public class ButtonPresses : MonoBehaviour {

	private GameObject player;
	public LayerMask UILayer;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update()
	{
		RaycastHit2D hit =  Physics2D.Raycast(Input.mousePosition, Vector3.forward, 1000, UILayer);
		if(Input.GetMouseButton(0))
		{
			if(hit.collider.name == "Fly Button")
			{
				Debug.Log ("Hitting fly bro");
				player.GetComponent<ControlScript>().MoveUp();
			}
		}
		if(Input.GetMouseButtonDown(0))
		{
			if(hit.collider.name == "Drop Button")
			{
				player.GetComponent<DropScript>().Spawn();
			}
		}
	}
}
