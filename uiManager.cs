﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour {

	public int score;
	public Text scoretxt;
	private bool gameOver;
	public Button[] buttons;
	GameObject player;


	void Start(){
		
		gameOver = false;
		score = 0;
		UpdateScore ();
	}

	public void AddScore (int newScoreValue){

		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore (){

		scoretxt.text = "SCORE: " + score;
	}

	public void GameOver(){
		player = GameObject.FindWithTag ("Player");
		Destroy (player);


		gameOver = true;
		foreach (Button button in buttons) {
			button.gameObject.SetActive (true);

		}
	}


	public void Pause(){

		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} 
		else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}

	public void Play(){
		SceneManager.LoadScene ("one");	
	}

	public void Menu(){
		SceneManager.LoadScene ("menu");
	}

}