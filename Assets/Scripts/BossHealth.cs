using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BossHealth : MonoBehaviour {

	public Slider healthSlider;
	public GameObject Explosion;
	public Rigidbody2D Boss;

	static public float currentHealth = 100;

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Bullet"){
			currentHealth -= 10;
			Object.Destroy(col.gameObject);
			//Object.Destroy(this.gameObject);
	}
	}

	void start(){
		healthSlider.value = currentHealth;
		Boss =  this.GetComponent<Rigidbody2D>();
		
	}

	void Update(){
		healthControl();
	}


	public void healthControl(){
		 healthSlider.value = currentHealth;

		if(currentHealth <= 0){
			Object.Destroy(this.gameObject);
			playExplosion();
			
			SceneManager.LoadSceneAsync("level 1");
		}
	}



	void playExplosion(){
	GameObject explosion = (GameObject) Instantiate (Explosion);

	explosion.transform.position = transform.position;
}
}
