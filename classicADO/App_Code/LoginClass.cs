using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //general data keys
using System.Data.SqlClient;//sqlserver data tools
using System.Configuration;//tools for talking to config file

/// <summary>
/// Summary description for LoginClass
/// </summary>
public class LoginClass
{
    SqlConnection connect;
    string user;
    string pass;

    public LoginClass(string username, string password)
    {

        user = username;
        pass = password;
        string connectString = ConfigurationManager.ConnectionStrings["CommunityConnection"].ToString();
        connect = new SqlConnection(connectString);
    }

    public int ValidateLogin()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connect;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "usp_Login";

        cmd.Parameters.AddWithValue("@Email", user);
        cmd.Parameters.AddWithValue("@password", pass);

        connect.Open();
        int result = cmd.ExecuteNonQuery();
        connect.Close();

        int key = 0;

        if (result != -1)
        {
            key = GetUserkey();
        }
        return key;
    }



    private int GetUserkey()
    {
        string sql = "Select PersonKey from Person where PersonEmail = @Email";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@Email", user);
        SqlDataReader reader = null;
        connect.Open();
        reader = cmd.ExecuteReader();

        int key = 0;

        while (reader.Read())
        {
            key = (int)reader["PersonKey"];
        }

        connect.Close();
        return key;

    }

}