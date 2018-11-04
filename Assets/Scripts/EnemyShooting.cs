using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {


   public Transform projectileSpawn;
   public GameObject projectile;

    public float nextFire = 1.0f;
   public float currentTime = 0.0f;
	// Use this for initialization
	void Start () {
		projectileSpawn = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		enemyShoot();
	}

	public void enemyShoot(){
		currentTime += Time.deltaTime;

		if(currentTime > nextFire){
			nextFire += currentTime;

			Instantiate(projectile, projectileSpawn.position, Quaternion.identity);

			nextFire -= currentTime;
			currentTime = 0.0f;
		}
	}
}