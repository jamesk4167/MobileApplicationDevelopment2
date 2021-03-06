﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using System.Configuration;
using System.EnterpriseServices;
using System.Security;
using System.IO;
using UnityEngine.UI;

public class dbRegister : MonoBehaviour {

	public InputField username, password, country;
	public Text Check;
	//create a constant dor the database connection(only way I could get this to work)
    private const string V = "/Plugins/users.s3db";

	private String Conn, sqlQuery;
	IDbConnection dbConn;
	IDbCommand DBcmd;

	

    // Use this for initialization
    void Start () {
		//open connection to database
		ConnectionDB();
		
		Readers();
		}

		public void ConnectionDB(){
     
 
         if (Application.platform != RuntimePlatform.Android) {
         
            Conn = "URI=file:" + Application.dataPath + V;
         } else {
 
             Conn = Application.persistentDataPath + V;
             if(!File.Exists(Conn)){
                 WWW load = new WWW ("jar:file://" + Application.dataPath + V); 
                 while (!load.isDone){
 
                 File.WriteAllBytes (Conn, load.bytes);
				 }
             }    
         }
  }


        
		public void Register(){
			if(username.text != string.Empty && password.text != string.Empty && country.text != string.Empty){
			InsertValue(username.text, password.text, country.text);
			Check.text = "Success";
			}else{
				Check.text = "All fields must be inputed";
			}
		}

		public void InsertValue(string username,string password,string country){
               using(dbConn = (IDbConnection)new SqliteConnection(Conn)){
                     dbConn.Open();
					 DBcmd = dbConn.CreateCommand();
					 
					 sqlQuery = string.Format("INSERT INTO Userinformation (username, password, country) VALUES (\"{0}\",\"{1}\",\"{2}\")",username,password,country);
					 DBcmd.CommandText = sqlQuery;
					 DBcmd.ExecuteScalar();
					 dbConn.Close();
			   }
		}



       public void SearchValue(string Username, string password){
                 using(dbConn = (IDbConnection)new SqliteConnection(Conn)){
                     dbConn.Open();
					 DBcmd = dbConn.CreateCommand();
					 sqlQuery = string.Format("SELECT * FROM Usersinfo WHERE (username, password) LIKE '%username%','%password%')",username, password);
					 DBcmd.CommandText = sqlQuery;
					 DBcmd.ExecuteScalar();
					 dbConn.Close();
				 }
	   }
	private void Readers(){
		using(dbConn = (IDbConnection)new SqliteConnection(Conn)){
			dbConn.Open();//open connection to the database
		    IDbCommand DBcmd = dbConn.CreateCommand();
            String sqlQuery = "SELECT * " + "FROM UsersInfo";
		    DBcmd.CommandText = sqlQuery;
		    IDataReader reader = DBcmd.ExecuteReader();
		    while(reader.Read()){
                int ID = reader.GetInt32(0);
			    string username = reader.GetString(1);
                string password = reader.GetString(2);
                string Country = reader.GetString(3);
            }

			reader.Close();
			reader = null;
			DBcmd.Dispose();
			DBcmd = null;
			dbConn.Close();
			dbConn = null;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
	
}
