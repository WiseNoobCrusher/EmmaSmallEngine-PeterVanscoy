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
    public partial class Customer_Edit : System.Web.UI.Page
    {
        private static CustomerDataset dsCustomer = new CustomerDataset();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                customerSubPageTableAdapter daSubPageCust = new customerSubPageTableAdapter();
                int id = Convert.ToInt32(Request.QueryString["val"]);

                daSubPageCust.Fill(dsCustomer.customerSubPage, id);

                foreach (DataRow r in dsCustomer.customerSubPage)
                {
                    txtFirst.Text = r.ItemArray[1].ToString();
                    txtLast.Text = r.ItemArray[2].ToString();
                    txtPhone.Text = r.ItemArray[3].ToString();
                    txtAddress.Text = r.ItemArray[4].ToString();
                    txtCity.Text = r.ItemArray[5].ToString();
                    txtPostal.Text = r.ItemArray[6].ToString();
                    txtEmail.Text = r.ItemArray[7].ToString();
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["val"]);
            var cnnString = global::EmmaSmallEngine.Properties.Settings.Default.EmmaConnectionString;
            var cmd = "UPDATE [dbo].[customer] SET custFirst = @FName, custLast = @LName, custPhone = @Phone, custAddress = @Address, custCity = @City, custPostal = @Postal, custEmail = @Email WHERE id = @id";
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                using (SqlCommand cmds = new SqlCommand(cmd, cnn))
                {
                    cmds.Parameters.AddWithValue("@id", id);
                    cmds.Parameters.AddWithValue("@FName", txtFirst.Text);
                    cmds.Parameters.AddWithValue("@LName", txtLast.Text);
                    cmds.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmds.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmds.Parameters.AddWithValue("@City", txtCity.Text);
                    cmds.Parameters.AddWithValue("@Postal", txtPostal.Text);
                    cmds.Parameters.AddWithValue("@Email", txtEmail.Text);

                    cnn.Open();
                    cmds.ExecuteNonQuery();
                }
            }
            Response.Redirect("~/Customer.aspx");
        }
    }
}