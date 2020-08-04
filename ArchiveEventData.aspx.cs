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
    public partial class ArchiveEventData : System.Web.UI.Page
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-BQH0FV2\SQLEXPRESS;Initial Catalog=EventOrganiserDB;Integrated Security = true;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnDelete.Enabled = false;
                FillGridView();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            hfContactID.Value = "";
            txtEventID.Text = txtEventName.Text = txtEventType.Text = txtDescription.Text = txtTime.Text = "";
            lblSuccessMessage.Text = lblErrorMessage.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("CreateOrUpdateEvent", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ConatctID", (hfContactID.Value == "" ? 0 : Convert.ToInt32(hfContactID.Value)));
            sqlCmd.Parameters.AddWithValue("@EventID", txtEventID.Text);
            sqlCmd.Parameters.AddWithValue("@EventName", txtEventName.Text);
            sqlCmd.Parameters.AddWithValue("@EventType", txtEventType.Text);
            sqlCmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            sqlCmd.Parameters.AddWithValue("@Time", txtTime.Text);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            string contactID = hfContactID.Value;
            Clear();
            if (contactID == "")
                lblSuccessMessage.Text = "Saved Successfully";
            else
                lblSuccessMessage.Text = "Updated Successfully";
            FillGridView();
        }

        void FillGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("ViewAllEvents", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            gvContact.DataSource = dtbl;
            gvContact.DataBind();

        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int eventID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SelectEvent", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@EventID", eventID);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            hfContactID.Value = eventID.ToString();
            txtEventID.Text = dtbl.Rows[0]["EventID"].ToString();
            txtEventName.Text = dtbl.Rows[0]["EventName"].ToString();
            txtEventType.Text = dtbl.Rows[0]["EventType"].ToString();
            txtDescription.Text = dtbl.Rows[0]["Description"].ToString();
            txtTime.Text = dtbl.Rows[0]["Time"].ToString();
            //btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        protected void btnArchive_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("ArchiveEventData", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@EventID", Convert.ToInt32(hfContactID.Value));
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            //Clear();
            //FillGridView();
            lblSuccessMessage.Text = "Archived selected events Successfully";
        }
    }
}