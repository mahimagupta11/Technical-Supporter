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
    public partial class logout : System.Web.UI.Page
    {

        singletonDbConnection obj = singletonDbConnection.getobj();
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session.Abandon();
                Session.Remove("username");
                Session.Remove("password");
                Response.Redirect("Index.aspx");
            }

            if (con.State != ConnectionState.Open) //connection object may have broken, executing, etc states so we should not use state==closed)
            {
                con.Close();
            }
        }
        
    }
    }

