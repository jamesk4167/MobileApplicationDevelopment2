using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using Mono.Data.Sqlite;

public class HighScoredb : MonoBehaviour {


   private const string V = "/Plugins/users.s3db";

    private String Conn, sqlQuery;
	IDbConnection dbConn;
	IDbCommand DBcmd;
	// Use this for initialization
	void Start () {
		Conn = "URI=file:" + Application.dataPath + V;
		GetScores();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


   private void AddScore(int newscore){
        using(dbConn = (IDbConnection)new SqliteConnection(Conn)){
			 dbConn.Open();
			 using (DBcmd = dbConn.CreateCommand()){
			     sqlQuery = string.Format("INSERT INTO HighScore(HighScore) VALUES({0})", newscore);
			     DBcmd.CommandText = sqlQuery;
			     DBcmd.Connection = dbConn;
			     
				    
				 dbConn.Close();
				 
			 
          }
		}
   }
	public void GetScores(){
		using(dbConn = (IDbConnection)new SqliteConnection(Conn)){
			 dbConn.Open();
			using (DBcmd = dbConn.CreateCommand()){
			     sqlQuery = string.Format("SELECT * FROM HighScore");
			     DBcmd.CommandText = sqlQuery;
			     DBcmd.Connection = dbConn;
			     using(IDataReader reader = DBcmd.ExecuteReader()){
				      while(reader.Read()){
					      Debug.Log(reader.GetString(1) +" " + reader.GetInt32(3)/* + reader.GetString(2) + reader.GetValue(0)*/);
					 
				 }
				 dbConn.Close();
				 reader.Close();
			 }
			}
		}
	}
}
