using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_remove_dept : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        dbconnect db6 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "select dept_id from tbl_dept";
        SqlDataReader dr1 = db6.executeread(cmd4);
        while (dr1.Read())
        {
            DropDownList1.Items.Add(dr1.GetString(0));
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db7 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "Delete from tbl_dept where dept_id=@did";
        cmd4.Parameters.AddWithValue("@did", DropDownList1.SelectedValue);
        db7.execute(cmd4);
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        dbconnect db8 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_dept where dept_id=@did";
        cmd5.Parameters.AddWithValue("@did", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db8.executeread(cmd5);
        dr1.Read();
        TextBox1.Text = dr1.GetString(1);
        TextBox2.Text = dr1.GetString(2);
        TextBox3.Text = dr1[3].ToString();


    }
}