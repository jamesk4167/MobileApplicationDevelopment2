using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

   public float MoveSpeed = 10.0f;
   public Rigidbody2D player;

   public Vector2 xconstraint;
   

   private Vector2 touchOrigin = Vector2.one;

   
	// Use this for initialization
	void Start () {
		
		player =  this.GetComponent<Rigidbody2D>();
	}
	
	
	void FixedUpdate () {
		
	#if UNITY_EDITOR
		MovePlayer();
	#else
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary){
			Vector2 touchPosition = Input.GetTouch(0).position;
			transform.position = new Vector2(Mathf.clamp(touchPosition.x, xconstraint.x, xconstraint.y), 0, 0);
			double halfScreen = Screen.width / 2.0;

			if(touchPosition.x < halfScreen){
				player.transform.Translate(Vector3.left * 5 * Time.deltaTime);
				
			}else if(touchPosition.x > halfScreen){
				player.transform.Translate(Vector3.right * 5 Time.deltaTime);
			}
		}
	#endif	

	}
	

	public void MovePlayer(){
		player.velocity = new Vector3(Input.GetAxis("Horizontal"), 0) * MoveSpeed;
	}

}
