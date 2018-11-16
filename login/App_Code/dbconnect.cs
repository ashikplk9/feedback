using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for dbconnect
/// </summary>
public class dbconnect
{
    public SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ashik\Documents\Visual Studio 2010\login\App_Data\tbl_login.mdf;Integrated Security=True;User Instance=True");
     public void execute(SqlCommand cmd)
         {
        cmd.Connection = cn; if (cn.State == ConnectionState.Open)
        {
            cn.Close();
        }
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }
    public SqlDataReader executeread(SqlCommand cmd)
    {
        cmd.Connection = cn;
        if (cn.State == ConnectionState.Open)
        {
            cn.Close();
        }
        cn.Open();
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        return dr;

    }
     public int id(SqlCommand cmd)
    {
        cmd.Connection = cn;
        if (cn.State == ConnectionState.Open)
        {
            cn.Close();
        }
        cn.Open();
        int x = Convert.ToInt32(cmd.ExecuteScalar());
        return x;
    }
	public dbconnect()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}