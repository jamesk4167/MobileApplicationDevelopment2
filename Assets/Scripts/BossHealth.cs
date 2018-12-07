using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour {

	public GameObject Explosion;
	public GameObject Boss;

	public Slider healthSlider;

    private float timer = 0;
	static public float currentHealth = 100;
	private int i = 0;

	void start(){
		healthSlider.value = currentHealth;
	}

	void Update(){
		healthControl();
		if(i > 0){
			timer += Time.deltaTime;
		}
	}


	public void healthControl(){
		 healthSlider.value = currentHealth;
         
		if(currentHealth <= 0){
			i = 1;
			//playerHealthScript.health += 1;
			
			if(timer >= 3){
			   SceneManager.LoadSceneAsync("Level 1");
			}
		}
	}


}