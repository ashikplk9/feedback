using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Tutor_add_sem : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dbconnect db20 = new dbconnect();
            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandText = "select DISTINCT course from tbl_dept";
            SqlDataReader dr1 = db20.executeread(cmd4);
            while (dr1.Read())
            {
                DropDownList1.Items.Add(dr1.GetString(0));

            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db21 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_dept where course=@cid";
        cmd5.Parameters.AddWithValue("@cid", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db21.executeread(cmd5);
        dr1.Read();
        while (dr1.Read())
        {
            DropDownList2.Items.Add(dr1.GetString(2));

        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db22 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_dept where stream=@sid";
        cmd5.Parameters.AddWithValue("@sid", DropDownList2.SelectedValue);
        SqlDataReader dr1 = db22.executeread(cmd5);
        dr1.Read();
        TextBox1.Text = Convert.ToString(dr1.GetInt32(3));
        TextBox2.Text = dr1.GetString(0);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        dbconnect db23 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "insert into tbl_sem values(@subcode,@deptid,@semno,@subject,@teacher)";
        cmd1.Parameters.AddWithValue("@subcode", TextBox4.Text);
        cmd1.Parameters.AddWithValue("@deptid", TextBox2.Text);
        cmd1.Parameters.AddWithValue("@semno", TextBox3.Text);
        cmd1.Parameters.AddWithValue("@subject", TextBox5.Text);
        cmd1.Parameters.AddWithValue("@teacher", "");
        db23.execute(cmd1);
        TextBox4.Text = "";
        TextBox5.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
}