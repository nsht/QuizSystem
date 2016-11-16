using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\HP\Documents\Visual Studio 2015\WebSites\QuizSystem\App_Data\Database.mdf;Integrated Security=True");
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
    SqlDataAdapter da;
    DataTable dt;
    String uName, pass;
    int uId;

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        //SqlCommand cmd = new SqlCommand("select * from User where User_Name='"+User_Name+"';",con);
        //cmd.ExecuteNonQuery();
        /* da = new SqlDataAdapter("select * from [User] WHERE User_Name='"+User_Name.Text+"'", con);
         dt = new DataTable();
         da.Fill(dt);

         uName = dt.Rows[0][1].ToString();
         pass = dt.Rows[0][2].ToString();
         */
        SqlCommand cmd = new SqlCommand("select User_Id,User_Name,Password from [User] where User_Name='" + User_Name.Text + "';", con);
        var rdr = cmd.ExecuteReader();
        if (rdr.HasRows)
        {
            while (rdr.Read())
            {
                uId = Convert.ToInt32(rdr[0]);
                uName = rdr[1].ToString();
                pass = rdr[2].ToString();
                string password =  ((TextBox)FindControl("Password")).Text;
                if(pass == password)
                {
                    Response.Write("<Script>alert('ok')</Script>");
                    HttpContext.Current.Session["username"] = uName;
                    HttpContext.Current.Session["uid"] = uId;
                    Response.Redirect("Userhome.aspx");
                }
                else
                {
                    Response.Write("<Script>alert('error')</Script>");
                }
                //Session("mname") = rdr[1];
                // Session("lname") = rdr[2];
            }
            //LoginStatus.Text = "SUCCESS !!";
            //Response.Redirect("~/CustomPages/Lecturer_PersonalDetailsPage.aspx");
            con.Close();


        }
        else
        {
            //LoginStatus.Text = "Invalid Username/Password";
            //TextBox1.Text = "";
            con.Close();
        }

    }
}