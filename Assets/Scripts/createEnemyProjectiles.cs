using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createEnemyProjectiles : MonoBehaviour {

    public Rigidbody2D projectile;

	public float moveSpeed = 15.0f;
	// Use this for initialization
	void Start () {
		projectile = this.gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		projectile.velocity = new Vector2 (0, -1) * moveSpeed;
	}
/* 
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			//Debug.Log("Hit the enemy");
            col.gameObject.SetActive(false);
	}
	   else if(col.gameObject.name == "BottomWall"){
		Object.Destroy (this.gameObject);
	}
	}*/
}

