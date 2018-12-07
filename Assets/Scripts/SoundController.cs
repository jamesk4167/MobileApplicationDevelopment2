using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundController : MonoBehaviour {


   
	// Use this for initialization
	void Start () {
		
	}
	

	private static SoundController instance = null;
	public static SoundController Instance{
		get {return instance; }
	}
	// Update is called once per frame
	void Awake () {
		if(instance != null && instance != this){
			Destroy(this.gameObject);
			return;
		}
		else{
			instance = this;
		}

		DontDestroyOnLoad(this.gameObject);
	}


	public void MuteCtrl(){
		if(PlayerPrefs.GetInt("Muted", 0) == 0){
			PlayerPrefs.SetInt("Muted", 1);
		}else{
			PlayerPrefs.SetInt("Muted",0);
		}

	}
}
