using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;



public class playerScore {
	public string PlayerName;
	public int PlayerScore;
   public playerScore(string PlayerName , int PlayerScore){
	   this.PlayerName = PlayerName;
	   this.PlayerScore = PlayerScore;
   }

   public string GetFormat(){
	   return PlayerName + "-S-" + PlayerScore;
   }
}
public class ScoreBoard : MonoBehaviour {


   public int scoreCount = 10;

   static ScoreBoard scoreBoard;
   static string seperator = "-S-";
	// Use this for initialization
	void Start () {
		scoreBoard = this;
	}
	
    void Update() {
		if(Input.GetKeyDown(KeyCode.S)){
        saveScore("james", 100);
		//saveScore("john", 200);
		saveScore("Mike", 500);
		}

        if(Input.GetKeyDown(KeyCode.P)){
			List<playerScore> playerScores = GetScores();
			foreach(playerScore p in playerScores){
				print(p.PlayerName + "         " + p.PlayerScore);
			}
		}

	}
	public static void saveScore(string name, int Value){
          List<playerScore> playerScores = new List<playerScore>();
		  for(int i = 0; i < scoreBoard.scoreCount; i++){
             if(PlayerPrefs.HasKey("score" + i)){
				 string[] scoreFormat = PlayerPrefs.GetString("score" + i).Split(new string [] {seperator}, System.StringSplitOptions.RemoveEmptyEntries);
                 playerScores.Add(new playerScore(scoreFormat[0],int.Parse(scoreFormat[0])));
			 }else{
				 break;
			 }
		  }if(playerScores.Count < 1){
			  PlayerPrefs.SetString("score0", name + seperator + Value);
			  print("test");
			  return;
		  }

		  playerScores.Add(new playerScore(name, Value));
		  playerScores = playerScores.OrderByDescending(o => o.PlayerScore).ToList();

		  for(int i = 0; i < scoreBoard.scoreCount; i++){
			  if(i >= playerScores.Count){ break; }
			  PlayerPrefs.SetString("Score" + i,playerScores[i].GetFormat());
		  }
	}
	// Update is called once per frame
	public List<playerScore> GetScores(){
		List<playerScore> playerScores = new List<playerScore>();
		for(int i = 0;i < scoreCount; i++){
           if(PlayerPrefs.HasKey("score" + i)){
			   string[] scoreFormat = PlayerPrefs.GetString("score" + i).Split(new string [] {seperator}, System.StringSplitOptions.RemoveEmptyEntries);
                playerScores.Add(new playerScore(scoreFormat[0],int.Parse(scoreFormat[1])));
		   }else{
			   break;
		   }
		}
		return playerScores;
	}
}
