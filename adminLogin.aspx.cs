using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = ((TextBox)FindControl("userAdmin")).Text;
        string password = ((TextBox)FindControl("passAdmin")).Text;
        if(username == "Admin" & password == "Admin")
        {
            Response.Redirect("Admin.aspx");
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
}