using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    
   
    
    private GameObject GameControllerGame;
    public static int scoreVal = 0;
	public Text score;
	// Use this for initialization
	void Start () {
		score = GameControllerGame.GetComponent<Text> ();
	}
	

	// Update is called once per frame
	void Update () {
		score.text = "score: " + scoreVal;
	}


}
