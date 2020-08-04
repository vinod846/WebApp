using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Event_OrganiserWebApp
{
    public partial class EventDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BQH0FV2\SQLEXPRESS;Initial Catalog=EventOrganiserDB;Integrated Security = true;");

        protected void Page_Load(object sender, EventArgs e)
        {
            //To establish database connection
            string dbConnection = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            var queryString = "select * From EventDetails";
            var dbconn = new SqlConnection(dbConnection);
            var dataAdapter = new SqlDataAdapter(queryString, dbconn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void lnk_Onclick(object sender, EventArgs e)
        {
            string eventID = (sender as LinkButton).CommandArgument;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SelectEvent", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@EventID", eventID);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            con.Close();
        }
    }
}