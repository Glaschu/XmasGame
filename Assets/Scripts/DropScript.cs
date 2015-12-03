using UnityEngine;
using System.Collections;

public class DropScript : MonoBehaviour {
	public GameObject[] obj;
	private ControlScript Controls;
	public int drop =0;
	public Transform dropPoint;

	public float dropTime;
	bool canDrop = false;
	float _canDrop;
	
	// Use this for initialization
	void Start () {
		Controls= GetComponent<ControlScript>();
	}

	void Awake()
	{
		_canDrop = dropTime;
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Spawn();
		}
		dropTime -= Time.deltaTime;
		if(dropTime <= 0)
		{
			canDrop = true;
		}

	}

	public void Spawn()
	{
		if(canDrop)
		{
			GameObject present = Instantiate(obj[0], new Vector3(dropPoint.position.x, dropPoint.position.y, dropPoint.position.z), Quaternion.identity) as GameObject;
			canDrop = false;
			dropTime = _canDrop;
		}
	}
}
