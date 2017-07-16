using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour {

	uiManager pointsToGive;
	public int newScore;
	GameObject thePlayer;
	playerHealth thePlayerHealth;


	// Use this for initialization
	void Start () {
		thePlayer = GameObject.FindGameObjectWithTag ("Player");
		thePlayerHealth = thePlayer.GetComponent<playerHealth> ();
		pointsToGive = FindObjectOfType<uiManager> ();
	}

	// Update is called once per frame
	void Update () {
		

	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			thePlayerHealth.addDamage (1);
			pointsToGive.AddScore (newScore);
		}
	}
}