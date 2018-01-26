using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {


	public void startGame(string gameScene){
		SceneManager.LoadScene (gameScene);
	}

	public void instructionsBtn(string helpScene){
		SceneManager.LoadScene (helpScene);
	}

	public void quitGame(){
		Application.Quit ();
	}
}
