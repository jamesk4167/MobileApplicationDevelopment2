using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour {



    public static CharacterSelector Instance;
    public static int playerNum;

	
	public void characterSelectorFunction(int selectedNum){
        playerNum = selectedNum;
		SceneManager.LoadSceneAsync("Level 1");
	}

	void Awake() {
		
		 if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
        }
	}
}
