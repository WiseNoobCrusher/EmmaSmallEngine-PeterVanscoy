using SalesDatasets;
using SalesDatasets.RepairDatasetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmmaSmallEngine
{
    public partial class Repairs_Delete : System.Web.UI.Page
    {
        private static RepairDataset dsCustomer = new RepairDataset();
        protected void Page_Load(object sender, EventArgs e)
        {
            repairTableAdapter daSubPageCust = new repairTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["val"]);

            daSubPageCust.Fill(dsCustomer.repair, id);

            foreach (DataRow r in dsCustomer.repair)
            {
                lblordNumber.Text = r.ItemArray[1].ToString();
                lblordDate.Text = r.ItemArray[2].ToString();
                lblserordDateIn.Text = r.ItemArray[3].ToString();
                lblserordDateOut.Text = r.ItemArray[4].ToString();
                lblserordIssue.Text = r.ItemArray[5].ToString();
                lblserordWarrenty.Text = r.ItemArray[6].ToString();
                lblserDescription.Text = r.ItemArray[7].ToString();
                lblserPrice.Text = r.ItemArray[8].ToString();
                lblordPaid.Text = r.ItemArray[9].ToString();
                lblCustomer.Text = r.ItemArray[10].ToString();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["val"]);
            var cnnString = global::EmmaSmallEngine.Properties.Settings.Default.EmmaConnectionString;
            var cmd = "DELETE FROM repairs WHERE id = @id";
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                using (SqlCommand cmds = new SqlCommand(cmd, cnn))
                {
                    cmds.Parameters.AddWithValue("@id", id);

                    cnn.Open();
                    cmds.ExecuteNonQuery();
                }
            }
            Response.Redirect("~/Repairs.aspx");
        }
    }
}