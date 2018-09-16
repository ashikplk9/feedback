using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

public partial class pdf_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string imageFilePath = Server.MapPath(".") + "/pdf/logo.jpg";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageFilePath);

            Document pdfDoc = new Document(PageSize.A4, 25, 10, 25, 10);
            jpg.Alignment = iTextSharp.text.Image.UNDERLYING;

            jpg.ScaleToFit(200,200);
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            Paragraph Text = new Paragraph("This is test file");
            pdfDoc.Add(jpg);
            pdfDoc.Add(Text);
            
            pdfWriter.CloseStream = false;
            pdfDoc.Close();
            Response.Buffer = true;
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Example.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(pdfDoc);
            Response.End();
            
        }
        catch (Exception ex)
        { Response.Write(ex.Message); } 
 
    }
}