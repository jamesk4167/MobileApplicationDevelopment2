using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBullet : MonoBehaviour {


   
   public Rigidbody2D bullet;

   public float moveSpeed = 10.0f;
	// Use this for initialization
	void Start () {
		
		bullet = this.gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		bullet.velocity = new Vector2 (0, 1) * moveSpeed;
	}
/* 
	void OnCollisionEnter2D(Collision2D col){

		if(col.gameObject.tag == "enemy"){
			
            col.gameObject.SetActive(false);
	}
		
	if(col.gameObject.name == "TopWall"){
		Object.Destroy(this.gameObject);
	}
}
*/
}