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
    public partial class WebForm10 : System.Web.UI.Page
    {
        int Cid;
        string Eid;
        // string cs = "Data Source=DESKTOP-2V8VSA9;Initial Catalog=TSS;Integrated Security=True";
        //SqlConnection con;
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
            
            string option= Request.QueryString["select"];

            string type= Request.QueryString["Complaint_Type"];
             Label1.Text ="Complaint Id="+ Request.QueryString["complaint_id"];

            if (option=="1")
            {
                con=obj.Con;
               // con = new SqlConnection(cs);
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "SELECT * FROM employee_details ";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                GridView1.DataSource = rd;
                GridView1.DataBind();
                con.Close();
            }


            else if (option == "2")
            {
                con = obj.Con;
               // con = new SqlConnection(cs);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM employee_details where working_department =(select dept_id from department where dept_name=@type)";
                cmd.Parameters.AddWithValue("@type", type);
                con.Open();
                SqlDataReader rd2 = cmd.ExecuteReader();
                GridView1.DataSource = rd2;
                GridView1.DataBind();
                con.Close();
            }
            else if (option == "3")
            {
                con=obj.Con;
                //con = new SqlConnection(cs);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM employee_details where emp_id NOT In (select distinct  assigned_to from complaints where assigned_to is not null)";
                con.Open();
                SqlDataReader rd2 = cmd.ExecuteReader();
                GridView1.DataSource = rd2;
                GridView1.DataBind();
                con.Close();
            }

        }
      


        protected void  OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[rowIndex];

                Eid = (row.FindControl("lbl_EID") as Label).Text;
               
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = obj.Con;
            //con = new SqlConnection(cs);
            Cid =Convert.ToInt32(Request.QueryString["complaint_id"].ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " Update Complaints set assigned_to = '" + Eid + "',complaint_status='" + "Assigned" + "' where complaint_Id = '" + Cid + "'";


                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    con.Close();
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Engineer Assigned!!');window.location.href='adminAssignedEngineerM.aspx';", true);

                }
                con.Close();
            }

            catch (Exception)
            {

            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminAssignedEngineerM.aspx");
        }
    }
}