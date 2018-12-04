using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {

   public bool paused;
   public GameObject pauseMenu;


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

	   }else if(!paused){
		   Time.timeScale = 1;
		   pauseMenu.SetActive(false);
	   }
}
   
   public void returnToMain(){
	   SceneManager.LoadSceneAsync("Menu");
   }
}
