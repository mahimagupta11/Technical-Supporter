using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        singletonDbConnection obj = singletonDbConnection.getobj();
        SqlConnection con;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
                Response.Write("<script> alert('You are already Logged In')</script> ");
            //else if()

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (AuthenticateUser(TextUsername.Text, TextPassword.Text))
            {
                Session["username"] = TextUsername.Text;
                Response.Redirect("ecPortalM.aspx");
            }
            else
            {
                Response.Write("<script> alert('Invalid User Name and/or Password')</script>");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            // using (SqlConnection con = new SqlConnection(strcon))
            // {
            con= obj.Con;
                
                        SqlCommand cmd = new SqlCommand("AuthenticateUser", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter paramUsername = new SqlParameter("@UserName", username);
                        SqlParameter paramPassword = new SqlParameter("@Password", password);

                        cmd.Parameters.Add(paramUsername);
                        cmd.Parameters.Add(paramPassword);
            if (con.State != ConnectionState.Open) //connection object may have broken, executing, etc states so we should not use state==closed)
            {
                con.Open();
            }
            int status;
             status = Convert.ToInt16(cmd.ExecuteScalar());
            con.Close();
            return status == 1;


          //  int ReturnCode = (int)cmd.ExecuteScalar();
               
            //    return ReturnCode == 1;
                       
                   // }


        }


    }


}


