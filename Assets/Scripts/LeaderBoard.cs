using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour {

    public Text[] HighScores;

	int[] HighScoreValues;


	// Use this for initialization
	void Start () {
	   HighScoreValues = new int[HighScores.Length];
	   for(int i = 0; i < HighScores.Length; i++){
		   HighScoreValues [i] = PlayerPrefs.GetInt("HighScoreValues" + i);
	   }
	   DrawScores();
	}



public void CheckForHighScore(int _Value){
	for(int i = 0; i < HighScores.Length; i++){
		if(_Value > HighScoreValues[i]){
			for(int j = HighScores.Length - 1; j > i; j-- ){
				HighScoreValues [j] = HighScoreValues[j -1];
			}
			HighScoreValues[i] = _Value;
			DrawScores();
			SaveScores();
			break;
		}
	}
}
	void SaveScores(){
		for(int i = 0; i< HighScores.Length; i++){
			PlayerPrefs.SetInt("HighScoreValues" + i, HighScoreValues[i]);
		}
	}

	void DrawScores(){
		for(int i = 0; i< HighScores.Length; i++){
			HighScores[i].text = HighScoreValues[i].ToString();
		}
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
