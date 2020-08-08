using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        // string cs = "Data Source=DESKTOP-2V8VSA9;Initial Catalog=TSS;Integrated Security=True";
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

        //ShowData method for Displaying Data in Gridview  
        protected void ShowData()
        {

            con = obj.Con;

            //con = new SqlConnection(cs);
            try
            {
                if (con.State != ConnectionState.Open) //connection object may have broken, executing, etc states so we should not use state==closed)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select complaint_Id,complaint_body,date_of_submission,submitted_by,complaint_status,Complaint_Type from Complaints where complaint_status = '" + "Pending" + "' ";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                GridView1.DataSource = rd;
                GridView1.DataBind();
                con.Close();
            }

            catch (Exception e)
            {
                Response.Write(e);
            }

        }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[rowIndex];
            string s1 = (row.FindControl("lbl_Id") as Label).Text;
            string s2 = (row.FindControl("lbl_CT") as Label).Text;

            if (e.CommandName == "View_All")
            {
                
                string s3 = "1";
                string url = string.Format("ChooseEngineerM.aspx?complaint_Id={0}&complaint_type={1}&select={2}",s1,s2,s3);
                Response.Redirect(url);
              
            }

            if (e.CommandName == "View_Suggested")
            {
                string s3 = "2";
                string url = string.Format("ChooseEngineerM.aspx?complaint_Id={0}&complaint_type={1}&select={2}", s1, s2, s3);
                Response.Redirect(url);


            }
            if (e.CommandName == "View_free")
            {
               
                string s3 = "3";
                string url = string.Format("ChooseEngineerM.aspx?complaint_Id={0}&complaint_type={1}&select={2}", s1, s2, s3);
                Response.Redirect(url);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPageM.aspx");
        }

       
    }
}