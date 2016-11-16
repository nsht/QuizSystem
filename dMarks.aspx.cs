using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class dMarks : System.Web.UI.Page
{
    double dMark;
    int uid,mAvg;
     
    protected void Page_Load(object sender, EventArgs e)
    {
        dMark = (double)(Session["tMarks"]);
        uid = (int)(Session["uid"]);
        dMarksL.Text = dMark.ToString();


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into Marks values(" + uid + ",'" + dMark + "')", con);
        cmd.ExecuteNonQuery();
        ///




    }
}