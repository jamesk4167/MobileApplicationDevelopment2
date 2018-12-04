using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

	public Slider healthSlider;

	static public float currentHealth = 100;

	void start(){
		healthSlider.value = currentHealth;
	}

	void Update(){
		healthControl();
	}


	public void healthControl(){
		 healthSlider.value = currentHealth;

		if(currentHealth <= 0){
			playerHealthScript.health -= 1;
			currentHealth = 100;
		}
	}
}
	

