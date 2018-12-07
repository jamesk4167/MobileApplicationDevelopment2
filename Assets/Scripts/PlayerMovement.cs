using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private float screenCenterX;
	public float moveSpeed = 5;
 
    private Rigidbody2D characterBody; 
    private void Start()
    {
        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
        //reference the rigidbody this script is attached too
		characterBody = this.GetComponent<Rigidbody2D> ();
    }
 
    private void Update()
    {
        // if there are any touches currently
        if(Input.touchCount > 0 )
        {
            // get the first one
            Touch firstTouch = Input.GetTouch(0);
 
            // if it began this frame
            if(firstTouch.phase == TouchPhase.Began)
            {
                if(firstTouch.position.x > screenCenterX)
                {
                    // if the touch position is to the right of center
                    // move right
					MoveCharacter (10.0f);
				
                }
                else if(firstTouch.position.x < screenCenterX)
                {
                    // if the touch position is to the left of center
                    // move left
					MoveCharacter (-10.0f);
                }
            }
        }
    }

void FixedUpdate(){
     #if UNITY_EDITOR
        MoveCharacter(Input.GetAxis("Horizontal") * moveSpeed);
     #endif
}
    //move the character
	private void MoveCharacter(float horizontalInput){
		characterBody.velocity = new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0);
		
	}
}