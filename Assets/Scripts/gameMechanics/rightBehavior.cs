using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightBehavior : MonoBehaviour {

	public float speed = -.2F;
	public Vector3 PlayerPos;
	public GameObject ball;

	Ball ballScript;
	scoreTracker scoreScript;

	void Start(){
		scoreScript = ball.GetComponent<scoreTracker>();
		ballScript = ball.GetComponent<Ball> ();
	}

	// Update is called once per frame
	void Update () {
		float yPos = gameObject.transform.position.y + (Input.GetAxis ("Horizontal") * speed);
		PlayerPos = new Vector3 (6.13F,Mathf.Clamp (yPos, -1.3F, 1.3F),0);
		gameObject.transform.position = PlayerPos;

	}

	void OnCollisionEnter(Collision col){
		scoreScript.incrementPoints ();
		ballScript.speedUp ();
	}
}
