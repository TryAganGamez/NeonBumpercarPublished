using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour {

	public Button[] buttons;

	bool gameOver;
	 

	void Start () {
	gameOver = false;
	

	}

	public void GameOver(){

		gameOver = true;
		foreach (Button button in buttons) {
			button.gameObject.SetActive (true);

		}
	}

	public void Play(){
		SceneManager.LoadScene ("one");

	}


	public void Exit(){
		Application.Quit ();

	}
}