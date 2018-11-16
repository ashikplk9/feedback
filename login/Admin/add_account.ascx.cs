using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_add_account : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            dbconnect db4 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select aid from tbl_key";
            SqlDataReader dr = db4.executeread(cmd1);
            dr.Read();
            int x = dr.GetInt32(0);
            x++;
            string aid = "ACC_" + x.ToString();
            TextBox1.Text = aid;

            dbconnect db3 = new dbconnect();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "update tbl_key set aid=@x";
            cmd2.Parameters.AddWithValue("@x", x);
            db3.execute(cmd2);


            dbconnect db5 = new dbconnect();
            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandText = "select dept_id from tbl_dept";
            SqlDataReader dr1 = db5.executeread(cmd4);
            while (dr1.Read())
            {
                DropDownList2.Items.Add(dr1.GetString(0));
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db5 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();

        cmd1.CommandText = "insert into tbl_account values(@aid,@name,@desig,@di,@em,@ph,@st)";
        cmd1.Parameters.AddWithValue("@aid", TextBox1.Text);
        cmd1.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd1.Parameters.AddWithValue("@desig", DropDownList1.SelectedValue);
        cmd1.Parameters.AddWithValue("di", DropDownList2.SelectedValue);
        cmd1.Parameters.AddWithValue("@em", TextBox3.Text);
        cmd1.Parameters.AddWithValue("@ph", TextBox4.Text);
        cmd1.Parameters.AddWithValue("@st", "ok");

        db5.execute(cmd1);
        
        dbconnect db6 = new dbconnect();
        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandText = "insert into tbl_login values(@ac,@p,@d)";
        cmd2.Parameters.AddWithValue("@ac", TextBox1.Text);
        cmd2.Parameters.AddWithValue("@p", TextBox4.Text);
        cmd2.Parameters.AddWithValue("@d", DropDownList1.SelectedValue);
        db6.execute(cmd2);
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}