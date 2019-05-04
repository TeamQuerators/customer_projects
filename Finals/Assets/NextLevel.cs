using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class NextLevel : MonoBehaviour
{
    public string username;
    public string stage;
    public int level;
    public int score;
    public int currency;
    public int star;

    // Start is called before the first frame update
    void Start()
    {
        string connection = "URI=file:" + Application.dataPath + "/cooking.db";

        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();
        Debug.Log("Open");

        IDbCommand cmnd = dbcon.CreateCommand();
        string query = "INSERT INTO `completed`(`username`,`stage`,`level`,`score`,`currency`,`star`)" +
                       "VALUES('"+ username + "','" + stage + "','" + level + "','" + score + "','" + currency + "','" + star + "')";
        cmnd.CommandText = query;
        cmnd.ExecuteNonQuery();

        // Close connection
        dbcon.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
