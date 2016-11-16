using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class question : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        da = new SqlDataAdapter("select * from Question;", con);
        dt = new DataTable();
        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        int qid = Convert.ToInt32(TextBox1.Text);
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        con.Open();
        SqlDataAdapter da;
        DataTable dt;

        da = new SqlDataAdapter("select * from Question WHERE Q_id=" + qid + "", con);
        dt = new DataTable();
        da.Fill(dt);

        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert(' Invalid ID')</script>");
        }
        else
        {

            TextBox1.Text = dt.Rows[0][0].ToString();
            TextBox7.Text = dt.Rows[0][1].ToString();
            TextBox2.Text = dt.Rows[0][2].ToString();
            TextBox3.Text = dt.Rows[0][3].ToString();
            TextBox4.Text = dt.Rows[0][4].ToString();
            TextBox5.Text = dt.Rows[0][5].ToString();
            TextBox6.Text = dt.Rows[0][6].ToString();

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
    //Update
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        SqlCommand cmd = new SqlCommand("update Question set Question='" + TextBox7.Text + "',O1="+TextBox2.Text+ " ,O2=" + TextBox3.Text +",03="+TextBox4.Text+ ",04="+TextBox4.Text+" WHERE Q_id=" + Convert.ToInt32(TextBox1.Text) + "", con);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("<script>alert('  updated')</script>");
        }
        else
        {
            Response.Write("<script>alert('  not updated')</script>");
        }

        con.Close();
    }
    //Insert
    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into Question values('" +TextBox7.Text + "','" + TextBox2.Text + "','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"')", con);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("<script>alert('  added')</script>");
        }
        else
        {
            Response.Write("<script>alert(' Error')</script>");
        }
    }


    // Delete
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        SqlCommand cmd = new SqlCommand("delete from Question where Q_id=" + Convert.ToInt32(TextBox1.Text) + "", con);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("<script>alert('  deleted')</script>");
        }
        else
        {
            Response.Write("<script>alert(' Invalid ID')</script>");
        }
        con.Close();
    }
}