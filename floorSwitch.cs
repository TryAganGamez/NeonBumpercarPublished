using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floorSwitch : MonoBehaviour {

	void Start(){


	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			//turn off circle

			gameObject.SetActive (false);
		}else gameObject.SetActive(true);
			} 
	}


