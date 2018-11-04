using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryEnemy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.name == "Bullet"){
			
			Object.Destroy(this.gameObject);
            col.gameObject.SetActive(false);
	}
}
}
