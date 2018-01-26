using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class endGame : MonoBehaviour {
	public Text endMessage;
	public Text restart;
	public GameObject ball;
	Ball ballScript;
	scoreTracker scoreScript;
	bool liveBall;

	void Start(){
		endMessage.text = "";
		restart.text = "";
		ballScript = ball.GetComponent<Ball>();
		scoreScript = ball.GetComponent<scoreTracker> ();
		liveBall = true;
	}

	void OnTriggerEnter(Collider other){
		endMessage.text = "Game Over!";
		restart.text = "Press Space to Restart";
		//Debug.Log ("HellO");
		//Debug.Log (ballScript);
		ballScript.transform.position = new Vector3 (0, 0, 0);
		ballScript.toggleGameState();
		liveBall = false;
		//Debug.Log (ballScript.gameOn);
	}

	void Update(){
		//Debug.Log (Input.GetKey (KeyCode.Space) && ballScript.gameOn == false);
		if (Input.GetKey (KeyCode.Space) && ballScript.gameOn == true && liveBall == false) {
			endMessage.text = "";
			restart.text = "";
			//Debug.Log ("Yes?");
			scoreScript.resetPoints ();
			liveBall = true;
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}


}
