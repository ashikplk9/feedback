using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

public partial class HOD_mapping : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String nm;
        nm = Convert.ToString(Session["us"]);
        dbconnect db11 = new dbconnect();
        SqlCommand cmd11 = new SqlCommand();
        cmd11.CommandText = "select dept_id from tbl_account where account_id=@id";
        cmd11.Parameters.AddWithValue("@id", nm);
        SqlDataReader dr11 = db11.executeread(cmd11);
        dr11.Read();
        TextBox3.Text = dr11.GetString(0);

        String d;
        d = TextBox3.Text;

        dbconnect db12 = new dbconnect();
        SqlCommand cmd12 = new SqlCommand();
        cmd12.CommandText = "select course,stream from tbl_dept where dept_id=@id";
        cmd12.Parameters.AddWithValue("@id", d);
        SqlDataReader dr12 = db12.executeread(cmd12);
        dr12.Read();
        TextBox1.Text = dr12.GetString(0);
        TextBox2.Text = dr12.GetString(1);

        dbconnect db1 = new dbconnect();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "select sem_no from tbl_sem";
        SqlDataReader dr1 = db1.executeread(cmd1);
        while (dr1.Read())
        {
            DropDownList1.Items.Add(dr1.GetString(0));
        }


    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db32 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_sem where sem_no=@sno";
        cmd5.Parameters.AddWithValue("@sno", DropDownList1.SelectedValue);
        SqlDataReader dr1 = db32.executeread(cmd5);
        dr1.Read();
        while (dr1.Read())
        {
            DropDownList2.Items.Add(dr1.GetString(3));

        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db22 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_account where dept_id=@did";
        cmd5.Parameters.AddWithValue("@did", TextBox3.Text);
        SqlDataReader dr1 = db22.executeread(cmd5);
        dr1.Read();
        while (dr1.Read())
        {
            DropDownList3.Items.Add(dr1.GetString(0));

        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnect db24 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "select * from tbl_account where dept_id=@did";
        cmd5.Parameters.AddWithValue("@did", TextBox3.Text);
        SqlDataReader dr1 = db24.executeread(cmd5);
        dr1.Read();
        TextBox4.Text = dr1.GetString(1);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnect db24 = new dbconnect();
        SqlCommand cmd5 = new SqlCommand();
        cmd5.CommandText = "update tbl_sem set teacher='" + TextBox4.Text + "' Where subject='" + DropDownList2.SelectedValue + "' ";
        db24.execute(cmd5);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string cs = TextBox1.Text;
        string stream =TextBox2.Text;
        string sno = DropDownList1.SelectedValue;
        string sub = DropDownList2.SelectedValue;
        string teacher = TextBox4.Text;
        try
        {
            string imageFilePath = Server.MapPath(".") + "/pdf/logo4.jpg";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageFilePath);

            Document pdfDoc = new Document(PageSize.A4, 25, 10, 25, 10);
            jpg.Alignment = iTextSharp.text.Image.UNDERLYING;

            jpg.ScaleToFit(600,510);
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            Paragraph Text = new Paragraph("Course :"+cs+ "\n Stream"+stream+ "\n Sem No :"+sno+ "\n Subject"+sub+ "\n Teacher :"+teacher+"\n" );
            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(new Phrase("Subject Data"));
            cell.Colspan = 2;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);
            table.AddCell("Course");
            table.AddCell(cs);
            table.AddCell("Stream");
            table.AddCell(stream);
            table.AddCell("Sem No");
            table.AddCell(sno);
            table.AddCell("Subject");
            table.AddCell(sub);
            table.AddCell("Teacher");
            table.AddCell(teacher);

            Text.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(jpg);
            pdfDoc.Add(Text);
            pdfDoc.Add(table);
            
            pdfWriter.CloseStream = false;
            pdfDoc.Close();
            Response.Buffer = true;
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Report.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(pdfDoc);
            Response.End();
            
        }
        catch (Exception ex)
        { Response.Write(ex.Message); } 
 
    }
    }