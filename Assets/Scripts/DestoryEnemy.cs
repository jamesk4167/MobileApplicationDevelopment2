using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryEnemy : MonoBehaviour {

	public GameObject Explosion;

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Bullet"){
			
			playExplosion();
			Object.Destroy(this.gameObject);
			Object.Destroy(col.gameObject);
            col.gameObject.SetActive(false);

			ScoreScript.scoreVal += 1;
	}
}

void playExplosion(){
	GameObject explosion = (GameObject) Instantiate (Explosion);

	explosion.transform.position = transform.position;
}
}
