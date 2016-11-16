using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Test : System.Web.UI.Page
{
    string user;
    public static string a1, a2, a3, a4, a5;
    public static int marks;
    double  tMarks;
    int uid;
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {

        user = (string)(Session["username"]);
        uid = (int)(Session["uid"]);

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
       // con.Open();
        //SqlCommand cmd = new SqlCommand("SELECT TOP 2 * FROM Question ORDER BY NEWID()", con);
        
    }


    protected void gTest(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        da = new SqlDataAdapter("SELECT TOP 5 * FROM Question ORDER BY NEWID()", con);
        dt = new DataTable();
        da.Fill(dt);
       // GridView1.DataSource = dt;
      //  GridView1.DataBind();


        Q.Text = dt.Rows[0][1].ToString();
        O1.Text = dt.Rows[0][2].ToString();
        O2.Text = dt.Rows[0][3].ToString();
        O3.Text = dt.Rows[0][4].ToString();
        O4.Text = dt.Rows[0][5].ToString();
        a1 = dt.Rows[0][6].ToString();

        Q0.Text = dt.Rows[1][1].ToString();
        O5.Text = dt.Rows[1][2].ToString();
        O6.Text = dt.Rows[1][3].ToString();
        O7.Text = dt.Rows[1][4].ToString();
        O8.Text = dt.Rows[1][5].ToString();
        a2 = dt.Rows[1][6].ToString();

        Q1.Text = dt.Rows[2][1].ToString();
        O9.Text = dt.Rows[2][2].ToString();
        O10.Text = dt.Rows[2][3].ToString();
        O11.Text = dt.Rows[2][4].ToString();
        O12.Text = dt.Rows[2][5].ToString();
        a3 = dt.Rows[2][6].ToString();

        Q2.Text = dt.Rows[3][1].ToString();
        O13.Text = dt.Rows[3][2].ToString();
        O14.Text = dt.Rows[3][3].ToString();
        O15.Text = dt.Rows[3][4].ToString();
        O16.Text = dt.Rows[3][5].ToString();
        a4 = dt.Rows[3][6].ToString();

        Q3.Text = dt.Rows[4][1].ToString();
        O17.Text = dt.Rows[4][2].ToString();
        O18.Text = dt.Rows[4][3].ToString();
        O19.Text = dt.Rows[4][4].ToString();
        O20.Text = dt.Rows[4][5].ToString();
        a5 = dt.Rows[0][6].ToString();
    }

    protected void Check_t(object sender, EventArgs e)
    {
       

        /////
        if (RadioButton1.Checked)
        {
            if (O1.Text == a1)
            {
                marks += 1;
            }

        }
        else if (RadioButton2.Checked)
        {
            if (O2.Text == a1)
            {
                marks += 1;
            }
        }
        else if (RadioButton3.Checked)
        {
            if (O3.Text == a1)
            {
                marks += 1;
            }
        }
        else if (RadioButton4.Checked)
        {
            if (O4.Text == a1)
            {
                marks += 1;
            }
        }


        //2
        if (RadioButton5.Checked)
        {
            if (O5.Text == a2)
            {
                marks += 1;
            }
        }
        else if (RadioButton6.Checked)
        {
            if (O6.Text == a2)
            {
                marks += 1;
            }
        }
        else if (RadioButton7.Checked)
        {
            if (O7.Text == a2)
            {
                marks += 1;
            }
        }
        else if (RadioButton8.Checked)
        {
            if (O8.Text == a2)
            {
                marks += 1;
            }
        }

        //3
        if (RadioButton9.Checked)
        {
            if (O9.Text == a3)
            {
                marks += 1;
            }
        }
        else if (RadioButton10.Checked)
        {
            if (O10.Text == a3)
            {
                marks += 1;
            }
        }
        else if (RadioButton11.Checked)
        {
            if (O11.Text == a3)
            {
                marks += 1;
            }
        }
        else if (RadioButton12.Checked)
        {
            if (O12.Text == a3)
            {
                marks += 1;
            }
        }

        //4

        if (RadioButton13.Checked)
        {
            if (O13.Text == a4)
            {
                marks += 1;
            }
        }
        else if (RadioButton14.Checked)
        {
            if (O14.Text == a4)
            {
                marks += 1;
            }
        }
        else if (RadioButton15.Checked)
        {
            if (O15.Text == a4)
            {
                marks += 1;
            }
        }
        else if (RadioButton16.Checked)
        {
            if (O16.Text == a4)
            {
                marks += 1;
            }
        }

        //5
        if (RadioButton17.Checked)
        {
            if (O17.Text == a5)
            {
                marks += 1;
            }
        }
        else if (RadioButton18.Checked)
        {
            if (O18.Text == a5)
            {
                marks += 1;
            }
        }
        else if (RadioButton19.Checked)
        {
            if (O19.Text == a5)
            {
                marks += 1;
            }
        }
        else if (RadioButton20.Checked)
        {
            if (O20.Text == a5)
            {
                marks += 1;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       

        

        tMarks = (double)marks / (double)5;
        tMarks = tMarks * 100;
        HttpContext.Current.Session["tMarks"] = tMarks;
        Response.Redirect("dMarks.aspx");
    }
}