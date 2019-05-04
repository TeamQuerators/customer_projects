using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class MenuCtrl : MonoBehaviour {

	public void LoadScene(string sceneName){

        /* string connection = "URI=file:" + Application.dataPath + "/cooking.db";

         IDbConnection dbcon = new SqliteConnection(connection);
         dbcon.Open();
         Debug.Log("Open");

         IDbCommand cmnd = dbcon.CreateCommand();
         IDataReader reader;
         string query = "SELECT * FROM complete";
         cmnd.CommandText = query;
         reader = cmnd.ExecuteReader();
         while (reader.Read())
         {
             Debug.Log("level: " + reader[0].ToString());

             if(reader[0].ToString() == 1) {
                btn 2 enable
             } else if(reader[0].ToString() == 2) {
                btn 3 enable
             }




             Debug.Log("username: " + reader[1].ToString());
         }

         // Close connection
         dbcon.Close(); */


        SceneManager.LoadScene (sceneName);
	}

}