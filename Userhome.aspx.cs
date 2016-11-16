using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Userhome : System.Web.UI.Page
{
    string user;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = (string)(Session["username"]);
        userLabel.Text = user;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Test.aspx");
    }

    protected void marks_Click(object sender, EventArgs e)
    {
        Response.Redirect("Marks.aspx");
    }
}