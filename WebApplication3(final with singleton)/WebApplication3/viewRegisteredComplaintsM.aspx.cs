using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;
using System.Configuration;

namespace WebApplication3
{
   

    public partial class WebForm14 : System.Web.UI.Page
    {
        singletonDbConnection obj = singletonDbConnection.getobj();
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
           // l1.Text = Request.QueryString["id"];

            if (!IsPostBack)
            {
                this.BindGrid(this.ShowData());
            }


        }

        public String getId()
        {
            String id;


            //string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(strcon))
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
            }
            catch (Exception e)
            {
                Response.Write(e);
            }
            com.ExecuteNonQuery();


                id = outparam.Value.ToString();

                con.Close();
            
                return id;
            
            //}

           
        }

        public List<complaint> ShowData()
        {
            string id = getId();


            // string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            //  using (SqlConnection con = new SqlConnection(strcon))
            // { 
            con = obj.Con; 
                string sqlText = @"select complaint_Id,complaint_body,date_of_submission,solution_suggested, complaint_status from Complaints
                                   WHERE submitted_by = @Eid AND NOT complaint_status = @status ";

                SqlCommand cmd1 = new SqlCommand(sqlText, con);
                cmd1.Parameters.AddWithValue("@Eid", id);
                cmd1.Parameters.AddWithValue("@status","Closed");
                con.Open();
                using (SqlDataReader sdr = cmd1.ExecuteReader())
                {
                    List<complaint> Acomp = new List<complaint>();
                    while (sdr.Read())
                    {

                        Acomp.Add(new complaint());
                        Acomp[Acomp.Count - 1].ComplaintId =(int) sdr["complaint_Id"];
                        Acomp[Acomp.Count - 1].Complaint_body = sdr["complaint_body"].ToString();
                        Acomp[Acomp.Count - 1].Date_of_submission = ((DateTime)sdr["date_of_submission"]); 
                        Acomp[Acomp.Count - 1].Sol_sugg = sdr["solution_suggested"].ToString();
                        Acomp[Acomp.Count - 1].Status = sdr["complaint_status"].ToString();
                    }
                   con.Close();
                    return Acomp;
                }
            //}
        }
        


        private void BindGrid(List<complaint> Acomp)
        {
            gvC.DataSource = Acomp;
            gvC.DataBind();
        }


        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            gvC.PageIndex = e.NewPageIndex;
            this.BindGrid(this.ShowData());
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Close")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvC.Rows[rowIndex];
                string datakey = gvC.DataKeys[row.RowIndex].Value.ToString();
                Response.Write(datakey);


                //string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                // using (SqlConnection con = new SqlConnection(strcon))

                // {
                con = obj.Con;
                    string sqlText = @"UPDATE Complaints 
                                       SET complaint_status = @cs   
                                       WHERE complaint_Id = @Id";
                    SqlCommand cmd1 = new SqlCommand(sqlText, con);
                    cmd1.Parameters.AddWithValue("@Id", datakey);
                    cmd1.Parameters.AddWithValue("@cs", "Closed");
                   con.Open();
                    cmd1.ExecuteNonQuery();
                con.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Complaint Closed Successfully');window.location.href='viewRegisteredComplaintsM.aspx';", true);

                   
                  
                //}
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ecPortalM.aspx");
        }


    }
}


