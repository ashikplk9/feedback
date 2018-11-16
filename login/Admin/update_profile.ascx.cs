using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_update_profile : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnect db15 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "select account_id from tbl_account";
        SqlDataReader dr1 = db15.executeread(cmd4);
        while (dr1.Read())
        {
            DropDownList1.Items.Add(dr1.GetString(0));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db17 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "update tbl_account set account_id='"+DropDownList1.SelectedValue+"',name='"+TextBox1.Text+"',designation='"+RadioButtonList1.SelectedValue+"',dept_id='"+TextBox2.Text+"',email='"+TextBox3.Text+"',phone='"+TextBox4.Text+"',status='ok' Where account_id='"+DropDownList1.SelectedValue+"' "; 
        /*cmd4.Parameters.AddWithValue("@aid", DropDownList1.SelectedValue);
        cmd4.Parameters.AddWithValue("@name", TextBox1.Text);
        cmd4.Parameters.AddWithValue("@desig", RadioButtonList1.SelectedValue);
        cmd4.Parameters.AddWithValue("di", TextBox2.Text);
        cmd4.Parameters.AddWithValue("@em", TextBox3.Text);
        cmd4.Parameters.AddWithValue("@ph", TextBox4.Text);
        cmd4.Parameters.AddWithValue("@st", "ok");*/
        db17.execute(cmd4);

        dbconnect db16 = new dbconnect();
        SqlCommand cmd7 = new SqlCommand();
        cmd7.CommandText = "update tbl_login set userid='" + DropDownList1.SelectedValue + "',pass='" + TextBox4.Text + "',type='" + RadioButtonList1.SelectedValue + "' Where userid='" + DropDownList1.SelectedValue + "' ";
        db16.execute(cmd7);
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Enabled = true;
        TextBox2.Enabled = true;
        TextBox3.Enabled = true;
        TextBox4.Enabled = true;

        dbconnect db19 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_account where account_id=@aid";
        cmd5.Parameters.AddWithValue("@aid", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db19.executeread(cmd5);
        dr1.Read();
        TextBox1.Text = dr1.GetString(1);
        TextBox2.Text = dr1.GetString(3);
        TextBox3.Text = dr1.GetString(4);
        TextBox4.Text = dr1.GetString(5);

        string des = dr1.GetString(2);
        string d = "HOD";
        if (des == d)
        {
            RadioButtonList1.Items[1].Selected = true;
        }
        else
        {
            RadioButtonList1.Items[0].Selected = true;
        }
       
    }
}