using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HOD_HOD_home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String nm;
        nm = Convert.ToString(Session["us"]);
        Label1.Text = nm;
        
    }
}