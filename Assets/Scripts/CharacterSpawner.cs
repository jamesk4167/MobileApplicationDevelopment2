using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour {

      public GameObject[] playerShips;
      public static Vector2 spawnPoint = new Vector2(0,-4);
      

   
	void Start () {
		if(PlayerPrefs.GetInt ("SelectedCharacter") == 0){
			Instantiate (playerShips[(0)], spawnPoint, Quaternion.identity);
		}
		if(PlayerPrefs.GetInt("SelectedCharacter") == 1){
			Instantiate (playerShips[(1)], spawnPoint, Quaternion.identity);
		}
		if(PlayerPrefs.GetInt("SelectedCharacter") == 2){
			Instantiate (playerShips[(2)], spawnPoint, Quaternion.identity);
		}
	}
}

	


	

