using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Event_OrganiserWebApp
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BQH0FV2\SQLEXPRESS;Initial Catalog=EventOrganiserDB;Integrated Security = true;");

        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-BQH0FV2\SQLEXPRESS;Initial Catalog=EventOrganiserDB;Integrated Security = true;"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM UserDetails WHERE UserName=@username AND Password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = txtUserName.Text.Trim();
                    //Response.Redirect("EventDetails.aspx");
                    var queryString = "SELECT EventID, EventName, EventType, Description, Time FROM UserEventDetails ued JOIN UserDetails ud ON ued.[User]=ud.UserName WHERE ud.UserName=" + txtUserName.Text;

                    string eventName = txtUserName.Text;
                    //SqlConnection sqlCon = new SqlConnection(conn);
                    //sqlCon.Open();
                    SqlCommand cmd = new SqlCommand();
                    SqlDataAdapter da = new SqlDataAdapter("ShowUserEvent", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@username", eventName);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    gvSearch.DataSource = dt;
                    gvSearch.DataBind();
                    sqlCon.Close();


                    //var dbconn = new SqlConnection();
                    //var dataAdapter = new SqlDataAdapter(queryString, sqlCon);

                    //var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    //var ds = new DataSet();
                    //dataAdapter.Fill(ds);

                    //GridView1.DataSource = ds.Tables[0];
                    //GridView1.DataBind();

                    //string eventID = (sender as LinkButton).CommandArgument;
                    //if (con.State == ConnectionState.Closed)
                    //    con.Open();
                    //SqlDataAdapter da = new SqlDataAdapter("ShowUserEvent", con);
                    //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.AddWithValue("@username", txtUserName.Text);
                    //DataTable dtbl = new DataTable();
                    //da.Fill(dtbl);
                    //con.Close();
                }
                else { lblErrorMessage.Visible = true; }
            }

            //var queryString = "SELECT EventID, EventName, EventType, Description, Time FROM UserEventDetails ued JOIN UserDetails ud ON ued.[User]=ud.UserName WHERE ud.UserName="+txtUserName.Text;
            //var dbconn = new SqlConnection();
            //var dataAdapter = new SqlDataAdapter(queryString, dbconn);

            //var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //var ds = new DataSet();
            //dataAdapter.Fill(ds);

            //GridView1.DataSource = ds.Tables[0];
            //GridView1.DataBind();

            
        }
        protected void lnk_Onclick(object sender, EventArgs e)
        {
            string eventID = (sender as LinkButton).CommandArgument;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter da = new SqlDataAdapter("ShowUserEvent", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@username", eventID);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            con.Close();
        }
    }
}