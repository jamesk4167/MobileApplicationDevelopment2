using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour {

      public GameObject[] playerShips;
      public static Vector2 spawnPoint = new Vector2(0,-4);
      

   
	void Start () {
		if(PlayerPrefs.GetInt ("selectedCharacter") == 0){
			Instantiate (playerShips[(0)], spawnPoint, Quaternion.identity);
		}
		if(PlayerPrefs.GetInt("selectedCharacter") == 1){
			Instantiate (playerShips[(1)], spawnPoint, Quaternion.identity);
		}
		if(PlayerPrefs.GetInt("selectedCharacter") == 2){
			Instantiate (playerShips[(2)], spawnPoint, Quaternion.identity);
		}
	}
}

	


	

