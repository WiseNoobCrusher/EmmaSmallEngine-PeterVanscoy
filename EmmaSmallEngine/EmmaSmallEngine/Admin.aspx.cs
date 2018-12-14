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
                string purchaseDate = row.ItemArray[0].ToString();

                if (purchaseDate.Contains(date))
                {
                    total += (Convert.ToDouble(row.ItemArray[1]) / .02);
                }
            }
            TextBox1.Text = total.ToString();
        }
    }
}