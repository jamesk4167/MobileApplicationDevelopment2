using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {



  //reference to the rigidbody
  public Rigidbody2D enemy;
//speed the enemy will move
   public float moveSpeed = 10.0f;

   public bool changeDirection = false;
	// Use this for initialization
	void Start () {
		enemy = this.gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		moveEnemy();
		
	}

	public void moveEnemy() {
		if(changeDirection == true){
            enemy.velocity = new Vector2 (1, 0) * -1 * moveSpeed ;
			
		}else if (changeDirection == false){
			
            enemy.velocity = new Vector2 (1, 0) * moveSpeed ;
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.name == "RightWall"){
			
			changeDirection = true;
		}
		
		else if(col.gameObject.name == "LeftWall"){
			
			changeDirection = false;
			
		}
 
		}
	}
	
	
    
	

