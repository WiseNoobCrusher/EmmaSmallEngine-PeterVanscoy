using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using EmmaSmallEngine;
using System.Data;
using SalesDatasets;
using SalesDatasets.SalesDatasetTableAdapters;
using System.Web.UI.WebControls;

namespace EmmaSmallEngine
{
    public partial class Admin : System.Web.UI.Page
    {
        // Declare a reference to the dataset
        private static SalesDataset dsSale;

        // Declare a reference to the rows of search records
        private static DataRow[] receipts;

        static Admin()
        {
            // Initialize the dataset
            dsSale = new SalesDataset();

            // Initialize the table adapters
            receiptTableAdapter daSales = new receiptTableAdapter();

            try
            {
                // Fill the data adapter with data from the dataset
                daSales.Fill(dsSale.receipt);
            }
            catch { }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ddlManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataRow row in receipts)
            {     
                string date = yearDDL.SelectedIndex.ToString();
                string purchaceDate = row.ItemArray[0].ToString();

                if (purchaceDate.Contains(date))
                {
                    total += (Convert.ToDouble(row.ItemArray[1]) / .02);
                }
            }
            TextBox1.Text = total.ToString();
        }
    }
}