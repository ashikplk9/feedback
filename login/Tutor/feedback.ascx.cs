using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Tutor_feedback : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
      /*  if (!IsPostBack)
        {

            dbconnect db4 = new dbconnect();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select fid from tbl_key";
            SqlDataReader dr = db4.executeread(cmd1);
            dr.Read();
            int x = dr.GetInt32(0);
            x++;
            string fid = "FED_" + x.ToString();
            TextBox6.Text = fid;

            dbconnect db3 = new dbconnect();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "update tbl_key set fid=@x";
            cmd2.Parameters.AddWithValue("@x", x);
            db3.execute(cmd2);
            Session["fid"] = TextBox6.Text;
        }*/
        dbconnect db6 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "select dept_id from tbl_dept";
        SqlDataReader dr1 = db6.executeread(cmd4);
        while (dr1.Read())
        {
            DropDownList4.Items.Add(dr1.GetString(0));
        }





    }
    
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db20 = new dbconnect();
        SqlCommand cmd4 = new SqlCommand();
        cmd4.CommandText = "select course,stream from tbl_dept where dept_id=@id";
        cmd4.Parameters.AddWithValue("@id", DropDownList4.SelectedValue);
        SqlDataReader dr23 = db20.executeread(cmd4);
        dr23.Read();
        TextBox1.Text = dr23.GetString(0);
        TextBox2.Text = dr23.GetString(1);
        
        dbconnect db1 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "select sem_no from tbl_sem";
        SqlDataReader dr1 = db1.executeread(cmd1);
        while (dr1.Read())
        {
            DropDownList5.Items.Add(dr1.GetString(0));
        }
    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db32 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_sem where sem_no=@sno";
        cmd5.Parameters.AddWithValue("@sno", DropDownList5.SelectedValue);
        SqlDataReader dr1 = db32.executeread(cmd5);
        dr1.Read();
        while (dr1.Read())
        {
            DropDownList3.Items.Add(dr1.GetString(3));

        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db24 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_sem where subject=@sid";
        cmd5.Parameters.AddWithValue("@sid", DropDownList3.SelectedValue);
        SqlDataReader dr45 = db24.executeread(cmd5);
        dr45.Read();
        TextBox3.Text = dr45.GetString(4);
        TextBox7.Text = dr45.GetString(0);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       /* Session["subject"] = DropDownList3.SelectedValue;
        Session["teacher"] = TextBox3.Text;
        Session["month"] = TextBox4.Text;
        Session["year"] = TextBox5.Text;
        int q = 1;
        dbconnect db5 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        
        

            cmd1.CommandText = "insert into stud_feedback values(@fid,@dept,@course,@stream,@sem,@sub,@teacher,@month,@year)";
            cmd1.Parameters.AddWithValue("@fid", TextBox6.Text);
            cmd1.Parameters.AddWithValue("@dept", DropDownList4.SelectedValue);
            cmd1.Parameters.AddWithValue("@course", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@stream", TextBox2.Text);
            cmd1.Parameters.AddWithValue("@sem", DropDownList5.SelectedValue);
            cmd1.Parameters.AddWithValue("sub", DropDownList3.SelectedValue);
            cmd1.Parameters.AddWithValue("@teacher", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@month", TextBox4.Text);
            cmd1.Parameters.AddWithValue("@year", TextBox5.Text);
            
            db5.execute(cmd1);
            SqlCommand cmd3 = new SqlCommand();
            while (q <= 18)
            {
                cmd3.CommandText = "insert into tbl_feedback values(@fid,@no,@op1,@op2,@op3,@op4,@op5,@op6)";
                cmd3.Parameters.AddWithValue("@fid", TextBox6.Text);
                cmd3.Parameters.AddWithValue("@no", q);
                cmd3.Parameters.AddWithValue("@op1", 0);
                cmd3.Parameters.AddWithValue("@op2", 0);
                cmd3.Parameters.AddWithValue("@op3", 0);
                cmd3.Parameters.AddWithValue("@op4", 0);
                cmd3.Parameters.AddWithValue("@op5", 0);
                cmd3.Parameters.AddWithValue("@op6", 0);
                q++;
                db5.execute(cmd3);
                cmd3.Parameters.Clear();
            }
            Response.Redirect("question.aspx");
        */
        Panel1.Visible = true;
        DropDownList4.Enabled = false;
        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        DropDownList5.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        dbconnect db27 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "Delete from tbl_feedback";
        db27.execute(cmd1);

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
         Session["subject"] = DropDownList3.SelectedValue;
        Session["teacher"] = TextBox3.Text;
        Session["month"] = TextBox4.Text;
        Session["year"] = TextBox5.Text;
        int q = 1;
        dbconnect db5 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        
        

            cmd1.CommandText = "insert into stud_feedback values(@fid,@dept,@course,@stream,@sem,@sub,@teacher,@month,@year,@subcod)";
            cmd1.Parameters.AddWithValue("@fid", TextBox6.Text);
            cmd1.Parameters.AddWithValue("@dept", DropDownList4.SelectedValue);
            cmd1.Parameters.AddWithValue("@course", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@stream", TextBox2.Text);
            cmd1.Parameters.AddWithValue("@sem", DropDownList5.SelectedValue);
            cmd1.Parameters.AddWithValue("sub", DropDownList3.SelectedValue);
            cmd1.Parameters.AddWithValue("@teacher", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@month", TextBox4.Text);
            cmd1.Parameters.AddWithValue("@year", TextBox5.Text);
            cmd1.Parameters.AddWithValue("@subcod", TextBox7.Text);
            db5.execute(cmd1);
            SqlCommand cmd3 = new SqlCommand();
            while (q <= 18)
            {
                cmd3.CommandText = "insert into tbl_feedback values(@fid,@no,@op1,@op2,@op3,@op4,@op5,@op6)";
                cmd3.Parameters.AddWithValue("@fid", TextBox7.Text);
                cmd3.Parameters.AddWithValue("@no", q);
                cmd3.Parameters.AddWithValue("@op1", 0);
                cmd3.Parameters.AddWithValue("@op2", 0);
                cmd3.Parameters.AddWithValue("@op3", 0);
                cmd3.Parameters.AddWithValue("@op4", 0);
                cmd3.Parameters.AddWithValue("@op5", 0);
                cmd3.Parameters.AddWithValue("@op6", 0);
                q++;
                db5.execute(cmd3);
                cmd3.Parameters.Clear();
            }
            Response.Redirect("question.aspx");
        
    }
}