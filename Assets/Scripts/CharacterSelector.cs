using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSelector : MonoBehaviour {
	
	public void characterSelectorFunction(int selectedCharacter){
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
		print(selectedCharacter);
	}

}
