using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	static public int presentScore=1;
	static public int presentMissed=0;
	public int happiness=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (presentMissed);
		HappinessLevel ();
	}

	void HappinessLevel(){
		happiness = presentScore / (presentScore + presentMissed);
	}
}
