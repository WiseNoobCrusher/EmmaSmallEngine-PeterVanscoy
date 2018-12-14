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
    public partial class Repairs_Edit : System.Web.UI.Page
    {
        private static RepairDataset dsRepair = new RepairDataset();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                repairTableAdapter daSubPageCust = new repairTableAdapter();
                int id = Convert.ToInt32(Request.QueryString["val"]);

                daSubPageCust.Fill(dsRepair.repair, id);

                foreach (DataRow r in dsRepair.repair)
                {
                    lblordNumber.Text = r.ItemArray[1].ToString();
                    lblordDate.Text = r.ItemArray[2].ToString();
                    lblserordDateIn.Text = r.ItemArray[3].ToString();
                    lblserordDateOut.Text = r.ItemArray[4].ToString();
                    lblserordIssue.Text = r.ItemArray[5].ToString();
                    lblserordWarrenty.Text = r.ItemArray[6].ToString();
                    lblserName.Text = r.ItemArray[7].ToString();
                    lblserDescription.Text = r.ItemArray[8].ToString();
                    lblserPrice.Text = r.ItemArray[9].ToString();
                    lblordPaid.Text = r.ItemArray[10].ToString();
                    lblCustomer.Text = r.ItemArray[11].ToString();
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["val"]);
            var cnnString = global::EmmaSmallEngine.Properties.Settings.Default.EmmaConnectionString;
            var cmd = "UPDATE [dbo].[customer] SET ordNumber = @ordNumber, ordDate = @ordDate, serordDateIn = @serordDateIn, serordDateOut = @serordDateOut, serordIssue = @serordIssue, serordWarrenty = @serordWarrenty, serName = @serName, serDescription = @serDescription, serPrice = @serPrice, ordPaid = @ordPaid, Customer = @Customer WHERE id = @id";
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                using (SqlCommand cmds = new SqlCommand(cmd, cnn))
                {
                    cmds.Parameters.AddWithValue("@id", id);
                    cmds.Parameters.AddWithValue("@ordNumber", lblordNumber.Text);
                    cmds.Parameters.AddWithValue("@ordDate", lblordDate.Text);
                    cmds.Parameters.AddWithValue("@serordDateIn", lblserordDateIn.Text);
                    cmds.Parameters.AddWithValue("@serordDateOut", lblserordDateOut.Text);
                    cmds.Parameters.AddWithValue("@serordIssue", lblserordIssue.Text);
                    cmds.Parameters.AddWithValue("@serordWarrenty", lblserordWarrenty.Text);
                    cmds.Parameters.AddWithValue("@serName", lblserName.Text);
                    cmds.Parameters.AddWithValue("@serDescription", lblserDescription.Text);
                    cmds.Parameters.AddWithValue("@serPrice", lblserPrice.Text);
                    cmds.Parameters.AddWithValue("@ordPaid", lblordPaid.Text);
                    cmds.Parameters.AddWithValue("@Customer", lblCustomer.Text);

                    cnn.Open();
                    cmds.ExecuteNonQuery();
                }
            }
            Response.Redirect("~/Repairs.aspx");
        }
    }
}