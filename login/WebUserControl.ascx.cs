using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class WebUserControl : System.Web.UI.UserControl
{
    dbconnect db = new dbconnect();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from tbl_login where userid=@ur and pass=@p";
        cmd.Parameters.AddWithValue("@ur", textuser.Text);
        cmd.Parameters.AddWithValue("@p", textpass.Text);

        SqlDataReader dr = db.executeread(cmd);
        if (dr.Read())
        {
            Session["us"] = textuser.Text;
          //  Session["pw"] = textpass.Text;
            string type = dr.GetString(2);
            if (type == "Admin")
            {
                Response.Redirect("Admin/Admin_home.aspx");
            }
            else if (type == "HOD")
            {
                Response.Redirect("HOD/HOD_home.aspx"); ;

            }
            else if (type == "Tutor")
            {
                Response.Redirect("tutor/tutor_home.aspx"); ;
            }
            
        }
        else
        { Label3.Visible = true; }

    }
}