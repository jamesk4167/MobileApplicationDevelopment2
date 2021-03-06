﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour {


   public float speed;
   //reference to the array of waypoints the boss moves around
   public Transform[] moveSpots;
   private int RandomSpots;

	// Use this for initialization
	void Start () {
		
		RandomSpots = Random.Range(0, moveSpots.Length);
	}
	
	// Update is called once per frame
	void Update () {
        //moves the boss around the array of waypoints
		transform.position = Vector2.MoveTowards(transform.position, moveSpots[RandomSpots].position, speed * Time.deltaTime);
	    
		if(Vector2.Distance(transform.position, moveSpots[RandomSpots].position) < 0.1f){
			RandomSpots = Random.Range(0,moveSpots.Length);
		}
	}
}
