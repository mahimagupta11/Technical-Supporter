using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        //string cs = "Data Source=DESKTOP-2V8VSA9;Initial Catalog=TSS;Integrated Security=True";
       // SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
         /*  if (!IsPostBack)
            {
               ShowData();
            }
             */
        }

        /*ShowData method for Displaying Data in Gridview  
        protected void ShowData()
        {
            con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select complaint_Id,complaint_body,date_of_submission,Complaint_Type,complaint_status,date_of_resolution from Complaints ";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            GridView1.DataSource = rd;
            GridView1.DataBind();
            con.Close();
        }
        */

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPageM.aspx");
        }
    }
}