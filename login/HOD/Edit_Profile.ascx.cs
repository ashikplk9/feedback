using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class HOD_Edit_Profile : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            String nm;
            nm = Convert.ToString(Session["us"]);
            dbconnect db33 = new dbconnect();
            SqlCommand cmd11 = new SqlCommand();
            cmd11.CommandText = "select dept_id from tbl_account where account_id=@id";
            cmd11.Parameters.AddWithValue("@id", nm);
            SqlDataReader dr11 = db33.executeread(cmd11);
            dr11.Read();
            TextBox1.Text = dr11.GetString(0);

            dbconnect db34 = new dbconnect();
            SqlCommand cmd5 = new SqlCommand();
            cmd5.CommandText = "select * from tbl_account where dept_id=@did";
            cmd5.Parameters.AddWithValue("@did", TextBox1.Text);
            SqlDataReader dr1 = db34.executeread(cmd5);
            dr1.Read();
            while (dr1.Read())
            {
                DropDownList1.Items.Add(dr1.GetString(0));

            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db35 = new dbconnect();
        SqlCommand cmd12 = new SqlCommand();
        cmd12.CommandText = "select * from tbl_account where account_id=@aid";
        cmd12.Parameters.AddWithValue("@aid", DropDownList1.SelectedValue);
        SqlDataReader dr12 = db35.executeread(cmd12);
        dr12.Read();
        
        TextBox3.Text = dr12.GetString(1);
        TextBox4.Text = dr12.GetString(4);
        TextBox5.Text = dr12.GetString(5);
        TextBox6.Text = dr12.GetString(6);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db35 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "update tbl_account set account_id='" + DropDownList1.SelectedValue + "',name='" + TextBox3.Text + "',email='" + TextBox4.Text + "',phone='" + TextBox5.Text + "',status='" + TextBox6.Text + "' Where account_id='" + DropDownList1.SelectedValue + "' ";
        db35.execute(cmd4);
    }
}