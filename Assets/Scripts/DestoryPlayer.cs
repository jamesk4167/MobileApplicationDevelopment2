using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPlayer : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "EnemyBullet"){
			//destroy the player
			//Object.Destroy(this.gameObject);
			//destroy the bullet
			Object.Destroy(col.gameObject);
            //col.gameObject.SetActive(false);
			playerHealth.currentHealth -= 20;

			
	}
	if(col.gameObject.tag == "EnemyBullet"){
			
            Object.Destroy(col.gameObject);
			playerHealthScript.health += 1;

			
	}

	if(col.gameObject.tag == "asteroid"){
			//destroy the player
			//Object.Destroy(this.gameObject);
			//destroy the Commit
			Object.Destroy(col.gameObject);
            //col.gameObject.SetActive(false);
			playerHealth.currentHealth -= 20;

	}
}
}
