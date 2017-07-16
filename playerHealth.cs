using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

	public float fullHealth;
	float currentHealth;

	public GameObject playerDeathFX;
	public Slider playerHealthSlider;
	public Image damageScreen;
	Color flasColor=new Color(255f,255f,255f,1f);
	float flashSpeed=5f;
	bool damaged=false;
	AudioSource myAudio;

	//public Text endGameText;
	//public restartGame game;


	// Use this for initialization
	void Awake () {
		currentHealth = fullHealth;
		playerHealthSlider.maxValue = fullHealth;
		playerHealthSlider.value = currentHealth;
	//	damaged = false;
		myAudio = GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void FixedUpdate () {
		if (damaged) {
			damageScreen.color = flasColor;
		} else {
			damageScreen.color = Color.Lerp (damageScreen.color, Color.clear, flashSpeed * Time.deltaTime);

		}
		damaged = false;
	}


	public void addDamage(float damage){
		currentHealth -= damage;
		playerHealthSlider.value = currentHealth;
		damaged = true;

		myAudio.Play ();

		if (currentHealth <= 0) {
			makeDead ();

		}
	}
	public void addHealth(float health){
		currentHealth += health;
		if(currentHealth>fullHealth) currentHealth = fullHealth;
		playerHealthSlider.value = currentHealth;
	}

	public void makeDead(){
		Instantiate(playerDeathFX,transform.position,Quaternion.Euler(new Vector3(-90,0,0)));
		damageScreen.color = flasColor;
		Destroy (gameObject);
	//	Animator endGameAnim = endGameText.GetComponent<Animator> ();
	//	endGameAnim.SetTrigger ("endGame");
	//	game.restartTheGame ();
	}
}
