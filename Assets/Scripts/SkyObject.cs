﻿using UnityEngine;
using System.Collections;

public class SkyObject : MonoBehaviour {

	public float speed = 3.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-Vector2.right * Time.deltaTime * speed);
	}
}
