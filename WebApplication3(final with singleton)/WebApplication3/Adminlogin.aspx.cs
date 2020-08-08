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
    public partial class Adminlogin : System.Web.UI.Page
    {
        singletonDbConnection obj = singletonDbConnection.getobj();
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
            {
         
            }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Session["username"] = TextUsername.Text;
            con = obj.Con;
            //string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;        (For singleton DB)
           // using (SqlConnection con = new SqlConnection(strcon))




          // using(con)                                             (For singleton DB, if using(con) used, gives exception)
           // {

                string query = "ADlogin";   //stored procedure Name
                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Username", TextUsername.Text.ToString());   //for username 
                com.Parameters.AddWithValue("@word", TextPassword.Text.ToString());  //for word
            if (con.State != ConnectionState.Open) //connection object may have broken, executing, etc states so we should not use state==closed)
            {
                con.Open();
            }
            
                int usercount = Convert.ToInt16(com.ExecuteScalar());// for taking single value
           
            if (usercount == 1)  // comparing users from table 
                {
                con.Close();
                Response.Redirect("AdminPageM.aspx");  //for sucsseful login
                }
                else
                {
                    con.Close();
                    Response.Write("<script> alert('Invalid User Name or word')</script>");  //for invalid login
                }
            

          //  }
        }

    
        }


    }





