using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Event_OrganiserWebApp
{
    public partial class AddEvent : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BQH0FV2\SQLEXPRESS;Initial Catalog=EventOrganiserDB;Integrated Security = true;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("usp_CreateEvent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Event_id", txtEventID.Text);
            cmd.Parameters.AddWithValue("@Event_name", txtEventName.Text);
            cmd.Parameters.AddWithValue("@Event_type", txtEventType.Text);
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@Time", txtTime.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            string flagged = hfvalue.Value;
            cmd.Parameters.Clear();
            if (flagged == "")
                lblSuccessMessage.Text = "Event created Successfully!!!!";
            else
                lblSuccessMessage.Text = "Event creation Unsuccessfully!!!";
            

        }
    }

}