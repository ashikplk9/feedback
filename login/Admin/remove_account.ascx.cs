using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_remove_account : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnect db9 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "select account_id from tbl_account";
        SqlDataReader dr1 = db9.executeread(cmd4);
        while (dr1.Read())
        {
            DropDownList1.Items.Add(dr1.GetString(0));
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        dbconnect db10 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_account where account_id=@aid";
        cmd5.Parameters.AddWithValue("@aid", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db10.executeread(cmd5);
        dr1.Read();
        TextBox4.Text = dr1.GetString(1);
        TextBox5.Text = dr1.GetString(2);
        TextBox6.Text = dr1.GetString(3);
        TextBox7.Text = dr1.GetString(4);
        TextBox8.Text = dr1.GetString(5);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db10 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "Delete from tbl_account where account_id=@aid";
        cmd4.Parameters.AddWithValue("@aid", DropDownList1.SelectedValue);
        db10.execute(cmd4);
        Panel1.Visible = false;
        }
}