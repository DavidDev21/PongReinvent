using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScale : MonoBehaviour {

	public int targetWidth = 705;
	public float pixelsToUnits = 20;
	public Camera camera;
	// Update is called once per frame
	void Update () {
		int height = Mathf.RoundToInt (targetWidth / (float)Screen.width * Screen.height);

		camera.orthographicSize = height / pixelsToUnits / 2;
		Debug.Log (camera.orthographicSize);
	}
}
