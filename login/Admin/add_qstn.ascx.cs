using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_add_qstn : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnect db11 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "select qid from tbl_key";
        SqlDataReader dr = db11.executeread(cmd1);
        dr.Read();
        int x = dr.GetInt32(0);
        x++;
        string qid = x.ToString();
        TextBox1.Text = qid;

        dbconnect db12 = new dbconnect();
        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandText = "update tbl_key set aid=@x";
        cmd2.Parameters.AddWithValue("@x", x);
        db12.execute(cmd2);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db13 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();

        cmd1.CommandText = "insert into tbl_qstn values(@qid,@qstn)";
        cmd1.Parameters.AddWithValue("@qid", TextBox1.Text);
        cmd1.Parameters.AddWithValue("@qstn",TextBox2.Text);
        db13.execute(cmd1);
    }
}