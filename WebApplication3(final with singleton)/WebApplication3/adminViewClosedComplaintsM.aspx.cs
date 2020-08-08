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
    public partial class WebForm12 : System.Web.UI.Page
    {
        //string cs = "Data Source=DESKTOP-2V8VSA9;Initial Catalog=TSS;Integrated Security=True";
        //SqlConnection con;
        singletonDbConnection obj = singletonDbConnection.getobj();
        SqlConnection con;

        SqlCommand cmd;
        int Cid;
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

                cmd = con.CreateCommand();
                cmd.CommandText = "select complaint_Id,complaint_body,date_of_submission,submitted_by,complaint_status,Complaint_Type from Complaints where complaint_status = '" + "Closed" + "' ";
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



        protected void OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[rowIndex];

                Cid = Convert.ToInt32((row.FindControl("lbl_Id") as Label).Text);

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con = new SqlConnection(cs);
            con = obj.Con;
            try
            {
                con.Open();
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                 cmd.CommandText = "delete from complaints where complaint_Id = '" + Cid + "'";


                int r =cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    con.Close();
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('complaint Permanently removed!!  Complaint id = " + Cid.ToString() + " ');window.location.href='adminViewClosedComplaintsM.aspx';", true);

                }
                con.Close();
            }

            catch (Exception)
            {

            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPageM.aspx");
        }
    }
}