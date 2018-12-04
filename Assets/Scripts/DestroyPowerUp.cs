using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUp : MonoBehaviour {

void OnCollisionEnter2d(Collision2D col){
	if(col.gameObject.tag == "BottomWall"){
			Object.Destroy(this.gameObject);
            
			

}
   if(col.gameObject.tag == "Player"){
			Object.Destroy(this.gameObject);
            
			playerHealthScript.health += 1;

}
}
}
