using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_WebUserControl : System.Web.UI.UserControl
{
    dbconnect db1 = new dbconnect();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
         dbconnect db2 = new dbconnect();
         SqlCommand cmd2 = new SqlCommand();
         cmd2.CommandText = "select * from tbl_key";
         SqlDataReader dr = db2.executeread(cmd2);
         dr.Read();
         int x = dr.GetInt32(1);
         x++;
         string did = "DEPT_" + x.ToString();
         TextBox1.Text = did;

         dbconnect db3 = new dbconnect();
         SqlCommand cmd3 = new SqlCommand();
         cmd3.CommandText = "update tbl_key set did=@x";
         cmd3.Parameters.AddWithValue("@x", x);
         db3.executeread(cmd3);



        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "insert into tbl_dept values(@did,@crs,@strm,@no)";
        cmd1.Parameters.AddWithValue("@did", TextBox1.Text);
        cmd1.Parameters.AddWithValue("@crs", TextBox2.Text);
        cmd1.Parameters.AddWithValue("@strm", TextBox3.Text);
        cmd1.Parameters.AddWithValue("@no", DropDownList1.SelectedValue);
        db1.execute(cmd1);
        Response.Redirect("Admin_home.aspx");
    }
}