using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public float presentScore=1;
	public float presentMissed=0;
	public float happiness;
	public GameObject presentCounter;
	public PresentCounter presentCount;
	// Use this for initialization
	void Start () {
		presentCounter = GameObject.Find("PressentHit");
		presentCount=GetComponent<PresentCounter>();
	}
	
	// Update is called once per frame
	void Update () {

		presentScore = presentCounter.gameObject.GetComponent<PresentCounter> ().presentHit;
		presentMissed = presentCounter.gameObject.GetComponent<PresentCounter> ().presentMissing;
		HappinessLevel ();
	}

	void HappinessLevel(){
		if (presentScore > 0) {
			happiness = (presentScore / (presentScore + presentMissed))*100;

		}
	}
}
