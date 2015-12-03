using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public int presentScore=1;
	public float presentMissed=0;
	public float happiness;
	public GameObject presentCounter;
	public PresentCounter presentCount;

	public Text scoreText;
	// Use this for initialization
	void Start () {
		presentCounter = GameObject.Find("PressentHit");
		presentCount=GetComponent<PresentCounter>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.GetComponent<Text>().text = presentScore.ToString();
		//presentScore = presentCounter.gameObject.GetComponent<PresentCounter> ().presentHit;
		//presentMissed = presentCounter.gameObject.GetComponent<PresentCounter> ().presentMissing;
		//HappinessLevel ();
	}

	void HappinessLevel(){
		if (presentScore > 0) {
			happiness = (presentScore / (presentScore + presentMissed))*100;

		}
	}
}
