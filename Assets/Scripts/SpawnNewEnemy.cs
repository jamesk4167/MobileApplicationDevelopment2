using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewEnemy : MonoBehaviour {
   //create reference to GameObject to spawn
   
   
   
   public GameObject enemy;

	// Update is called once per frame
	void Update () {
		Spawning();
	}

	void Spawning(){
		if(!GameObject.FindGameObjectWithTag("enemy")){
			Instantiate (enemy, transform.position, Quaternion.identity );
		}
	}
	}

