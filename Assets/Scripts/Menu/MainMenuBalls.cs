using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBalls : MonoBehaviour {

	public float ballVelocity;
	Rigidbody body;
	int randint;

	void Awake()
	{
		body = gameObject.GetComponent<Rigidbody> ();
		randint = Random.Range (1, 5);
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
