using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {


public Animator animate;
[SerializeField]
private float DelayBeforeLoading = 5.0f;

 [SerializeField]
 private int loadLevel;
 
 //public Text DisplayTimer;
 private GameObject GameController;
 private float timer = 0;
 


void Start(){
  
}
  void Update(){
    updateAfterTime();
  }

void updateAfterTime(){
  timer += Time.deltaTime;
    if(timer >= DelayBeforeLoading){
       FadeToLevel(loadLevel);
     }
}

public void FadeToLevel(int levelIndex){
  loadLevel = levelIndex;
 animate.SetTrigger("Fade_out");
}

public void WhenFadeDone(){
  SceneManager.LoadSceneAsync(loadLevel);
}

}


