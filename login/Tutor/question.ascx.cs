using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Tutor_question : System.Web.UI.UserControl
{

    public static int i = 1;
    public static int count;
    protected void Page_Load(object sender, EventArgs e)
    {
        String sub, tchr;
        string m, y;
        string fid;
        fid = Convert.ToString(Session["fid"]);
        sub = Convert.ToString(Session["subject"]);
        tchr = Convert.ToString(Session["teacher"]);
        m = Convert.ToString(Session["month"]);
        y = Convert.ToString(Session["year"]);
        Label1.Text = Convert.ToString(m);
        Label2.Text = Convert.ToString(y);
        Label3.Text = sub;
        Label4.Text = tchr;
        Label9.Text = fid;


        if (!IsPostBack)
        {
         
            dbconnect db1 = new dbconnect();
            dbconnect db2 = new dbconnect();
              SqlCommand cmd = new SqlCommand();
              cmd.CommandText = "select * from tbl_qstn where qno=" + i + "";
              SqlCommand cmd1 = new SqlCommand();
              cmd1.CommandText = "select count(*) from tbl_qstn";
              count =db2.id(cmd1);
              SqlDataReader dr = db1.executeread(cmd);

              while (dr.Read())
              {
                  Label5.Text = dr[0].ToString();
                  TextBox1.Text = dr[1].ToString();
              }

          }
      }
      protected void Button1_Click(object sender, EventArgs e)
      {
          if (i > 1)
          {
              i--;


              dbconnect db2 = new dbconnect();

              SqlCommand cmd = new SqlCommand();
              cmd.CommandText = "select * from tbl_qstn where qno=" + i + "";
         
              SqlDataReader dr = db2.executeread(cmd);

              while (dr.Read())
              {
                  Label5.Text = dr[0].ToString();
                  TextBox1.Text = dr[1].ToString();
              }
          }
      }
      protected void Button2_Click(object sender, EventArgs e)
      {

          if (i < count)
          {
              i++;

              dbconnect db = new dbconnect();
              SqlCommand cmd = new SqlCommand();
              cmd.CommandText = "select * from tbl_qstn where qno=" + i + "";
            
              SqlDataReader dr = db.executeread(cmd);

              while (dr.Read())
              {
                  Label5.Text = dr[0].ToString();
                  TextBox1.Text = dr[1].ToString();
              }
          }
        }
    }






