using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour {


   public static CharacterSpawner Instance;
  

    public GameObject[] characters;
	public Transform playerSpawn;
	// Use this for initialization


   
	void Start () {
		Instantiate (characters[CharacterSelector.playerNum], playerSpawn.position, playerSpawn.rotation );
	}
	}

	


	

