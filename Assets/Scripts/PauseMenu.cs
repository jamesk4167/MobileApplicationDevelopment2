using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenu : MonoBehaviour {


    public GameObject pausePanel, pauseButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pause(){
        Time.timeScale = 0;
		pauseButton.SetActive(false);
		pausePanel.SetActive(true);
		
	}

	public void unpause(){
        Time.timeScale = 1;
	    pauseButton.SetActive(true);
		pausePanel.SetActive(false);
		
	}

	public void QuitGame(){
		Application.Quit();
	}
}
