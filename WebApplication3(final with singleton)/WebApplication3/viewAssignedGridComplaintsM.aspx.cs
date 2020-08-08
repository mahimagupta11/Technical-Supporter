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
    public partial class WebForm13 : System.Web.UI.Page
    {

        singletonDbConnection obj = singletonDbConnection.getobj();
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
           // l1.Text = Request.QueryString["id"];

            if (!IsPostBack)
            {
                ShowData();
            }

        }

        public String getId()
        {
            String id;
            // string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            // using (SqlConnection con = new SqlConnection(strcon))
            //{
            con = obj.Con;
                SqlCommand com = new SqlCommand("ReturnId", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@username", Session["username"]);

                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@id";
                outparam.SqlDbType = System.Data.SqlDbType.VarChar;
                outparam.Direction = System.Data.ParameterDirection.Output;
                outparam.Size = 50;
                com.Parameters.Add(outparam);
            try
            {
                if (con.State != ConnectionState.Open) //connection object may have broken, executing, etc states so we should not use state==closed)
                {
                    con.Open();
                }
                    com.ExecuteNonQuery();

                    id = outparam.Value.ToString();

                    con.Close();
               
                return id;
            }
            catch (Exception e)
            {
                Response.Write(e);
            }

            //}
            return null;
        }

        //ShowData method for Displaying Data in Gridview  
        protected void ShowData()
        {
            string id = getId();
            //string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(strcon))
            //{
            con = obj.Con;
                string sqlText = @"select complaint_Id,complaint_body,date_of_submission,solution_suggested ,date_of_resolution,Complaint_Type,complaint_status from Complaints
                                   WHERE assigned_to = @Eid AND NOT complaint_status = @status ";

                SqlCommand cmd1 = new SqlCommand(sqlText, con);
                cmd1.Parameters.AddWithValue("@Eid", id);
                cmd1.Parameters.AddWithValue("@status", "Closed");
                con.Open();
                SqlDataReader rd = cmd1.ExecuteReader();
            if (!rd.HasRows)
            {
                //con.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No More Assigned complaints!!');window.location.href='ecPortalM.aspx';", true);

            }
            else
            {
                GridView1.DataSource = rd;
                GridView1.DataBind();

                //following code->only for the purpose of storing result in class(not needed otherwise)
                List<complaint> Acomp = new List<complaint>();
                while (rd.Read())
                {

                    Acomp.Add(new complaint());
                    Acomp[Acomp.Count - 1].ComplaintId = (int)rd["complaint_Id"];
                    Acomp[Acomp.Count - 1].Complaint_body = rd["complaint_body"].ToString();
                    Acomp[Acomp.Count - 1].Date_of_submission = (DateTime)rd["date_of_submission"];
                    Acomp[Acomp.Count - 1].Sol_sugg = rd["solution_suggested"].ToString();
                    Acomp[Acomp.Count - 1].Date_of_resolution = (DateTime)rd["date_of_resolution"];
                    Acomp[Acomp.Count - 1].Type = rd["Complaint_Type"].ToString();
                    Acomp[Acomp.Count - 1].Status = rd["complaint_status"].ToString();
                }
            }
                con.Close();
            //}
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            ShowData();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            ShowData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label cid = GridView1.Rows[e.RowIndex].FindControl("lbl_Id") as Label;
            TextBox solution = GridView1.Rows[e.RowIndex].FindControl("txt_SS") as TextBox;
            Label Rdate = GridView1.Rows[e.RowIndex].FindControl("lbl_Rdate") as Label;

            string Status = (GridView1.Rows[e.RowIndex].FindControl("ddl_Status") as DropDownList).SelectedItem.Value;
            DateTime date = DateTime.UtcNow;
            Rdate.Text = date.ToShortDateString();

            // string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            // using (SqlConnection con = new SqlConnection(strcon))
            // {
            con = obj.Con;
                string sqlText = @"UPDATE Complaints 
                                   SET solution_suggested= @ss,
                                        complaint_status = @cs,
                                        date_of_resolution=@rd       
                                       WHERE complaint_Id = @Id";
                SqlCommand cmd = new SqlCommand(sqlText, con);
                cmd.Parameters.AddWithValue("@Id", cid.Text);
                cmd.Parameters.AddWithValue("@ss", solution.Text);
                cmd.Parameters.AddWithValue("@cs", Status);
                cmd.Parameters.Add("@rd", SqlDbType.Date).Value = date.Date;
                con.Open();
                cmd.ExecuteNonQuery();

                GridView1.EditIndex = -1;
                ShowData();
                con.Close();
           // }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ecPortalM.aspx");
        }

    }
}