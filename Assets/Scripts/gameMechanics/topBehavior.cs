using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topBehavior : MonoBehaviour {
	
	public float speed = -.5F;
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
		float xPos = gameObject.transform.position.x + (Input.GetAxis ("Horizontal") * speed);
		PlayerPos = new Vector3 (Mathf.Clamp (xPos, -4.4F, 4.4F), 2.96F, 0);
		gameObject.transform.position = PlayerPos;

	}

	void OnCollisionEnter(Collision col){
		scoreScript.incrementPoints ();
		ballScript.speedUp ();
	}
}
