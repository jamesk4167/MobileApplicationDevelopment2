using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewEnemy : MonoBehaviour {
   //create reference to GameObject to spawn
   
   
   public float timer = 0;
   public GameObject enemy;

	// Update is called once per frame
	void Update () {
		SpawningEnemyShips();
	}

	void SpawningEnemyShips(){

		timer += Time.deltaTime;
		if(!GameObject.FindGameObjectWithTag("enemy") && timer >= 3){
			Instantiate (enemy, transform.position, Quaternion.identity );
			timer = 0;
		}

	}

	void SpawningCommits(){
		if(!GameObject.FindGameObjectWithTag("asteroid") && timer >= 3){
			Instantiate (enemy, transform.position, Quaternion.identity );
			timer = 0;
		}
		}
	}

