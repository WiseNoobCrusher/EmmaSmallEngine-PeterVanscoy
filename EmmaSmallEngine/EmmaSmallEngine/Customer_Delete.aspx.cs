using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SalesDatasets;
using SalesDatasets.CustomerDatasetTableAdapters;

namespace EmmaSmallEngine
{
    public partial class Customer_Delete : System.Web.UI.Page
    {
        private static CustomerDataset dsCustomer = new CustomerDataset();
        protected void Page_Load(object sender, EventArgs e)
        {
            customerSubPageTableAdapter daSubPageCust = new customerSubPageTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["val"]);

            daSubPageCust.Fill(dsCustomer.customerSubPage, id);

            foreach (DataRow r in dsCustomer.customerSubPage)
            {
                lblFirst.Text = r.ItemArray[1].ToString();
                lblLast.Text = r.ItemArray[2].ToString();
                lblPhone.Text = r.ItemArray[3].ToString();
                lblAddress.Text = r.ItemArray[4].ToString();
                lblCity.Text = r.ItemArray[5].ToString();
                lblPostal.Text = r.ItemArray[6].ToString();
                lblEmail.Text = r.ItemArray[7].ToString();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["val"]);
            var cnnString = global::EmmaSmallEngine.Properties.Settings.Default.EmmaConnectionString;
            var cmd = "DELETE FROM customer WHERE id = @id";
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                using (SqlCommand cmds = new SqlCommand(cmd, cnn))
                {
                    cmds.Parameters.AddWithValue("@id", id);

                    cnn.Open();
                    cmds.ExecuteNonQuery();
                }
            }
            Response.Redirect("~/Customer.aspx");
        }
    }
}