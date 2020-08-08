using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class HomePage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // string user =(string) Session["username"];
            if (Session["username"] == null)
                LinkButton2.Visible = false;
            else if (Session["username"] != null ) 
            {
                   LinkButton1.Visible = false; // emp login
                    LinkButton2.Visible = true; // logout
                    LinkButton3.Visible = false; // admin login
            }

            else if (Session["username"].Equals("Admin"))
            {
                LinkButton1.Visible = false;
                LinkButton2.Visible = true;
                LinkButton3.Visible = false;
            }

}

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("logout.aspx");

        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Adminlogin.aspx");

        }




    }
}