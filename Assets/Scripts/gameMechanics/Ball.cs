using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float ballVelocity = 300F;
	float initalVelocity = 300F;
	public bool gameOn = false;

	Rigidbody body;
	int randint;
	float dirX;
	float dirY;
	// Awake is called when the Ball is created.
	void Awake()
	{
		body = gameObject.GetComponent<Rigidbody> ();
		randint = Random.Range (1, 5);
		gameObject.transform.position = new Vector3(0, 0, 0);
	}

	// Update is called once per frame
	void Update () 
	{
		Debug.Log (body.velocity);
		// Start the ball at some random direction. 
		if (Input.GetKey (KeyCode.Space) && gameOn == false) {
			//Debug.Log ("I am here");
			transform.parent = null;
			gameOn = true;
			body.isKinematic = false;

			if (randint == 1) {
				body.AddForce (new Vector3 (ballVelocity, ballVelocity, 0));
			} else if (randint == 2) {
				body.AddForce (new Vector3 (-ballVelocity, -ballVelocity, 0));
			} else if (randint == 3) {
				body.AddForce (new Vector3 (ballVelocity, -ballVelocity, 0));
			} else if (randint == 4) {
				body.AddForce (new Vector3 (-ballVelocity, ballVelocity, 0));
			}
		} 
	}

	public void toggleGameState(){
		gameOn = !gameOn;
		body.velocity = new Vector3 (0, 0, 0);
		randint = Random.Range (1, 5);
		ballVelocity = initalVelocity;
	}

	public void speedUp(){
		//ballVelocity += 0F;
		dirX = Mathf.Sign(transform.position.x);
		dirY = Mathf.Sign(transform.position.y);
		body.AddForce (new Vector3 (15F * dirX, 15F * dirY, 0));
	}
}
