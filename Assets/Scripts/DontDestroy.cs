using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour {

	public GameObject Heart1, Heart2, Heart3;


	

	void Awake () {
		DontDestroyOnLoad(this.gameObject);
	}
}
