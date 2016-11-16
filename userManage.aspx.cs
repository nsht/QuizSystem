using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class userManage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select * from [User];", con);
        dt = new DataTable();
        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        SqlCommand cmd = new SqlCommand("delete from [User] where User_id=" + Convert.ToInt32(TextBox1.Text) + "", con);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("<script>alert(' User deleted')</script>");
        }
        else
        {
            Response.Write("<script>alert(' Invalid ID')</script>");
        }
        con.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        SqlCommand cmd = new SqlCommand("update [User] set User_Name='" + TextBox2.Text + "' WHERE User_id=" + Convert.ToInt32(TextBox1.Text) + "", con);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("<script>alert(' User name updated')</script>");
        }
        else
        {
            Response.Write("<script>alert(' User name not updated')</script>");
        }

        con.Close();
    }
}