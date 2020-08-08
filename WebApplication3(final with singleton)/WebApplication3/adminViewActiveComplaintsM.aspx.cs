using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        // string connectionString = ConfigurationManager.ConnectionStrings["TSSConnectionString"].ConnectionString;
        // SqlConnection con;
        singletonDbConnection obj = singletonDbConnection.getobj();
        SqlConnection con;
      
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                ShowData();
            }

        }

       
        protected void ShowData()
        {
            con = obj.Con;
            //con = new SqlConnection(connectionString);
            try
            {
                if (con.State != ConnectionState.Open) //connection object may have broken, executing, etc states so we should not use state==closed)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select complaint_Id,complaint_body,date_of_submission,Complaint_Type,complaint_status,date_of_resolution from Complaints where NOT complaint_status='" + "Closed" + "' ";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                GridView1.DataSource = rd;
                GridView1.DataBind();
                con.Close();
            }
            catch(Exception e)
            {
                Response.Write(e);
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPageM.aspx");
        }
    }
}