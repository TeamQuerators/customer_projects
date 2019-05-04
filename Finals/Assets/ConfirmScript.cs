using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmScript : MonoBehaviour
{ 
    public Button confirmBtn;
    public InputField usernameIF;

    // Start is called before the first frame update
    void Start()
    {
        confirmBtn.onClick.AddListener(RegisterUser);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RegisterUser()
    {
        string connection = "URI=file:" + Application.dataPath + "/cooking.db";

        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        IDbCommand cmnd = dbcon.CreateCommand();
         cmnd.CommandText = "INSERT INTO `account` (`username`) " +
                             "VALUES ('" + usernameIF.text  + "')";

        try
        {
            cmnd.ExecuteNonQuery();
        } catch (System.Exception e) {
            Debug.Log("Username already exist");
        }
         

        // Close connection
        dbcon.Close();
    }
}
