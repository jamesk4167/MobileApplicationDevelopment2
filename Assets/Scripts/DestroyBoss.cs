using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyBoss : MonoBehaviour {



public GameObject Explosion;

void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Bullet"){
			
			//destroy the bullet
			Object.Destroy(col.gameObject);
			BossHealth.currentHealth -= 10;
			
			checkIfDead();
			
	}
}



void checkIfDead(){
	//checks if the boss has been destroyed
	if(BossHealth.currentHealth <= 0){
		   //adds 1 to the player health
			playerHealthScript.health += 1;
			//destroys the boss
			Object.Destroy(this.gameObject);
			ScoreScript.scoreVal += 10;
			playerHealthScript.health += 1;
			//Instantiates the explosion
			playExplosion();
	}
}
	void playExplosion(){
	GameObject explosion = (GameObject) Instantiate (Explosion);

	explosion.transform.position = transform.position;
}
}
