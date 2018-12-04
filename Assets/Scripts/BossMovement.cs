using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour {


   public float speed;
   public Transform[] moveSpots;
   private int RandomSpots;

	// Use this for initialization
	void Start () {
		RandomSpots = Random.Range(0, moveSpots.Length);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position, moveSpots[RandomSpots].position, speed * Time.deltaTime);
	    
		if(Vector2.Distance(transform.position, moveSpots[RandomSpots].position) < 0.2f){
			RandomSpots = Random.Range(0,moveSpots.Length);
		}
	}
}
