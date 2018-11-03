using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

   public float MoveSpeed = 10.0f;
   public Rigidbody2D player;

   
	// Use this for initialization
	void Start () {
		
		player =  this.GetComponent<Rigidbody2D>();
	}
	
	
	void FixedUpdate () {
		MovePlayer ();
	}

	public void MovePlayer(){
		player.velocity = new Vector3(Input.GetAxis("Horizontal"), 0) * MoveSpeed;
	}

	
}
