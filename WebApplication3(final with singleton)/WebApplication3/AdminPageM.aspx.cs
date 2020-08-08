using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminViewAllComplaintsM.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminViewActiveComplaintsM.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminViewClosedComplaintsM.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminAssignedEngineerM.aspx");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminGenerateReport_Rdlc.aspx");
        }
    }
}