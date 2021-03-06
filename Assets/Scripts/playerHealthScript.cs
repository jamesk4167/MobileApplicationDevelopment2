﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealthScript : MonoBehaviour {

   //Create a static instance of playerHealthScript to make it a singleton
   //public static playerHealthScript Instance;
   //reference the hearts
   
    
   private int Score;
   
   public GameObject Heart1, Heart2, Heart3, Explosion;
   static public int health = 3;
  
  

  
	
	// Use this for initialization
	void Start () {
		    //health = MaxHealth;
		    Heart1.gameObject.SetActive(true);
		    Heart2.gameObject.SetActive(true);
		    Heart3.gameObject.SetActive(true);
	}
   

   
	
	// Update is called once per frame
	void Update () {
		HeartsUpdate();
		
	}

     void HeartsUpdate(){
		if(health > 3){
			health = 3;
		}

		switch (health) {
		   case 3: 
		      Heart1.gameObject.SetActive(true);
		      Heart2.gameObject.SetActive(true);
		      Heart3.gameObject.SetActive(true);
			  break;
		  case 2: 
		      Heart1.gameObject.SetActive(true);
		      Heart2.gameObject.SetActive(true);
		      Heart3.gameObject.SetActive(false);
			  break;
		 case 1: 
		      Heart1.gameObject.SetActive(true);
		      Heart2.gameObject.SetActive(false);
		      Heart3.gameObject.SetActive(false);
			  break;
		case 0: 
		      Heart1.gameObject.SetActive(false);
		      Heart2.gameObject.SetActive(false);
		      Heart3.gameObject.SetActive(false);
			  playExplosion();
		      EndGame();
			  this.enabled = false;
			  break;
		}

		}
			void EndGame(){
			//coma back to here GetComponent<AudioManager>().CheckForHighScore(Score);
			SceneManager.LoadSceneAsync("LeaderBoardMenu");
			//check the score from the ScoreScript
			Score = ScoreScript.scoreVal;
			GetComponent<LeaderBoard>().CheckForHighScore(Score);
			
	}
       public void playExplosion(){
		   GameObject explosion = (GameObject) Instantiate (Explosion);

	       explosion.transform.position = transform.position;
	   }
}
