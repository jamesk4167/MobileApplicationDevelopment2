using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour {


    private SoundController soundctrl;
	
	
	public Text Muted;
	// Use this for initialization
	void Start () {
		soundctrl = GameObject.FindObjectOfType<SoundController>();
		UpdateText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void muteMusic(){
		soundctrl.MuteCtrl();
		UpdateText();
	}

	void UpdateText(){
		if(PlayerPrefs.GetInt("Muted", 0) == 0){
			AudioListener.volume = 1;
		    Muted.text = "Not Muted"; 
		}else{
            AudioListener.volume = 0;
			Muted.text = "Muted"; 		
			}
	}
}
