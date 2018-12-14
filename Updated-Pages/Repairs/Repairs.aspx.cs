using SalesDatasets;
using SalesDatasets.RepairDatasetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmmaSmallEngine
{
    public partial class Repairs : System.Web.UI.Page
    {
        private static RepairDataset dsCustomer = new RepairDataset();

        protected void Page_Load(object sender, EventArgs e)
        {
            repairTableAdapter daCustomer = new repairTableAdapter();

            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Login.aspx");
            }

            daCustomer.Update(dsCustomer);
            daCustomer.Fill(dsCustomer.customer);

            foreach (DataRow r in dsCustomer.customer)
            {
                TableRow tblRow = new TableRow();

                TableCell linkButtons = new TableCell();
                TableCell ordNumber = new TableCell();
                TableCell ordDate = new TableCell();
                TableCell serordDateIn = new TableCell();
                TableCell serordDateOut = new TableCell();
                TableCell serordIssue = new TableCell();
                TableCell serordWarranty = new TableCell();
                TableCell serName = new TableCell();
                TableCell serDescription = new TableCell();
                TableCell serPrice = new TableCell();
                TableCell ordPaid = new TableCell();
                TableCell Customer = new TableCell();


                linkButtons.Controls.Add(new LinkButton { Text = "Edit", PostBackUrl = "Customer_Edit.aspx?val=" + r.ItemArray[0].ToString() });
                linkButtons.Controls.Add(new Literal { Text = "<br />" });
                linkButtons.Controls.Add(new LinkButton { Text = "Delete", PostBackUrl = "Customer_Delete.aspx?val=" + r.ItemArray[0].ToString() });

                ordNumber.Text = r.ItemArray[1].ToString();
                ordDate.Text = r.ItemArray[2].ToString();
                serordDateIn.Text = r.ItemArray[3].ToString();
                serordDateOut.Text = r.ItemArray[4].ToString();
                serordIssue.Text = r.ItemArray[5].ToString();
                serordWarranty.Text = r.ItemArray[6].ToString();
                serName.Text = r.ItemArray[7].ToString();
                serDescription.Text = r.ItemArray[8].ToString();
                serPrice.Text = r.ItemArray[9].ToString();
                ordPaid.Text = r.ItemArray[10].ToString();
                Customer.Text = r.ItemArray[11].ToString();
  
                tblRow.Cells.Add(linkButtons);
                tblRow.Cells.Add(ordNumber);
                tblRow.Cells.Add(ordDate);
                tblRow.Cells.Add(serordDateIn);
                tblRow.Cells.Add(serordDateOut);
                tblRow.Cells.Add(serordIssue);
                tblRow.Cells.Add(serordWarranty);
                tblRow.Cells.Add(serName);
                tblRow.Cells.Add(serDescription);
                tblRow.Cells.Add(serPrice);
                tblRow.Cells.Add(ordPaid);
                tblRow.Cells.Add(Customer);

                this.tblRepairs.Rows.Add(tblRow);
            }

            this.ddlManagement.Items[0].Attributes.Add("style", "color:#009900");
            this.ddlManagement.Items[0].Attributes.Add("disabled", "disabled");
        }

        protected void ddlManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = this.ddlManagement.SelectedValue;

            this.ddlManagement.Items[0].Attributes.Add("style", "color:#009900");
            this.ddlManagement.Items[0].Attributes.Add("disabled", "disabled");

            this.ddlManagement.Items[0].Selected = true;

            Response.Redirect("~/" + temp + ".aspx");
        }
    }
}