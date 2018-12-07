using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {


   public Text DisplayTimer;
   private GameObject GameController;
   private float countDown = 60;
	// Use this for initialization
	void Start () {
		DisplayTimer = GameObject.Find("timer").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		countDown -= Time.deltaTime;
		DisplayTimer.text = "time:" + Mathf.Round(countDown);
	}

	
}
