using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

   public Transform projectileSpawn;
   public GameObject bullet;

   public float nextFire = 1.0f;
   public float currentTime = 0.0f;
	// Use this for initialization
	void Start () {
		projectileSpawn = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		shoot();
	}

	public void shoot(){
		currentTime += Time.deltaTime;

		if(currentTime > nextFire){
			nextFire += currentTime;

			Instantiate(bullet, projectileSpawn.position, Quaternion.identity);

			nextFire -= currentTime;
			currentTime = 0.0f;
		}
	}
}