using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        singletonDbConnection obj = singletonDbConnection.getobj();
        SqlConnection con;
        // SqlConnection con;
        //string cs = "Data Source=DESKTOP-2V8VSA9;Initial Catalog=TSS;Integrated Security=True";
        string id;
        string name="";
        protected void Page_Load(object sender, EventArgs e)
        {
            // con = new SqlConnection(cs);
            con = obj.Con;
            try
            {
                if (con.State != ConnectionState.Open) //connection object may have broken, executing, etc states so we should not use state==closed)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("select emp_id from login_details where username ='" + Session["username"] + "'");
                using (SqlDataReader sr = cmd.ExecuteReader())
                {
                    sr.Read();
                    id = sr.GetValue(0).ToString();
                }

                cmd.CommandText = ("select emp_name from employee_details where emp_id='" + id + "' ");
                using (SqlDataReader sr = cmd.ExecuteReader())
                {
                    sr.Read();
                    name = sr.GetValue(0).ToString();
                }

                Label1.Text = "Welcome " + name + "!!";
                con.Close();
            }
            catch(Exception er)
            {
                Response.Write(er);
            }
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("registerComplaintsM.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string url;
            url = "viewRegisteredComplaintsM.aspx";
            Response.Redirect(url);
           

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string url;
            url = "viewAssignedGridComplaintsM.aspx";
            Response.Redirect(url);
           
        }

        
    }
}