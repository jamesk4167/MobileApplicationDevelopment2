using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class dbLogin : MonoBehaviour {


    public InputField username, password;
	public Text Check;

	//create a constant dor the database connection(only way I could get this to work)
    private const string V = "/Plugins/users.s3db";

	private String Conn, sqlQuery;
	IDbConnection dbConn;
	IDbCommand DBcmd;
	// Use this for initialization
	void Start () {
		Conn = "URI=file:" + Application.dataPath + V;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Login(){
			if(username.text != string.Empty && password.text != string.Empty){
                 SearchValue(username.text, password.text);
			}
	}



	public void SearchValue(string Username, string password){
                 using(dbConn = (IDbConnection)new SqliteConnection(Conn)){
					 int count = 0;
                     dbConn.Open();
					 DBcmd = dbConn.CreateCommand();
					 sqlQuery = string.Format("SELECT * FROM Usersinfo WHERE username= '" + Username + "'");
					 DBcmd.CommandText = sqlQuery;
					 DBcmd.Connection = dbConn;
					 IDataReader reader = DBcmd.ExecuteReader();
					 while(reader.Read()){
                       count++;
					 }
					 if(count == 1){
						 Check.text = "Successful Login!";
						 //Usernames = Username;
						 //this.Close();
					 }
					 else{
						 Check.text = "Username or password Wrong!";
					 }
					 dbConn.Close();
				 }
		
	   }
}
