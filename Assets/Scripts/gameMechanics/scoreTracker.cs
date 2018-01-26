using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTracker : MonoBehaviour {

	public int points;
	public Text score;

	// Use this for initialization
	void Start () {
		points = 0;
		score.text = "Score: " + points.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + points.ToString ();
	}

	public void incrementPoints(){
		points += 1;
	}

	public void resetPoints(){
		points = 0;

	}

}
