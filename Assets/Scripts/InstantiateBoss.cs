using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBoss : MonoBehaviour {


   public GameObject boss;
   public static Vector2 spawnpoint = new Vector2(0,3);
	// Use this for initialization
	void Start () {
		Instantiate(boss,spawnpoint, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
