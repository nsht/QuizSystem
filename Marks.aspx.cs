using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Marks : System.Web.UI.Page
{
    string user,suid;
    int uid,marks,mAvg;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = (string)(Session["username"]);
        uid = (int)(Session["uid"]);
        userLabelM.Text = user;
        
        // uid = Convert.ToInt32(suid);

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT AVG(Test_Marks),COUNT(" + uid + ") FROM Marks where User_id = " + uid + "", con);
        var rdr = cmd.ExecuteReader();
        if (rdr.HasRows)
        {
            while (rdr.Read())
            {

                mAvg = Convert.ToInt32(rdr[0]);
            }

            con.Close();


        }
        else
        {
            userMarksM.Text = "You have not taken a test yet";
            con.Close();
        }



        userMarksM.Text = mAvg.ToString();
    }

}