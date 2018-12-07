using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour {

   public bool paused;
   public GameObject pauseMenu, BackGroundButtons;
   


   void Start(){
	   paused = false;
   }

   void Update(){
	   
   }

   public void Pause(){
        
		   paused = !paused;

	   if(paused){
		   Time.timeScale = 0;
		   pauseMenu.SetActive(true);
		   BackGroundButtons.SetActive(false);

	   }else if(!paused){
		   Time.timeScale = 1;
		   pauseMenu.SetActive(false);
		   //backGroundButtons.SetActive(true);
		   BackGroundButtons.SetActive(true);
	   }
}
   
   public void returnToMain(){
	   SceneManager.LoadSceneAsync("Menu");
   }
}
