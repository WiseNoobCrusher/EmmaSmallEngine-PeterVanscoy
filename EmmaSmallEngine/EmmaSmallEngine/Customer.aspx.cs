using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SalesDatasets;
using SalesDatasets.CustomerDatasetTableAdapters;


namespace EmmaSmallEngine
{
    public partial class Customer : System.Web.UI.Page
    {
        private static CustomerDataset dsCustomer = new CustomerDataset();

        protected void Page_Load(object sender, EventArgs e)
        {
            customerTableAdapter daCustomer = new customerTableAdapter();

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
                TableCell firstName = new TableCell();
                TableCell lastName = new TableCell();
                TableCell phoneNumber = new TableCell();
                TableCell custAddress = new TableCell();
                TableCell custCity = new TableCell();
                TableCell custPostal = new TableCell();
                TableCell emailAddress = new TableCell();

                linkButtons.Controls.Add(new LinkButton { Text = "Edit", PostBackUrl = "Customer_Edit.aspx?val="+r.ItemArray[0].ToString() });
                linkButtons.Controls.Add(new Literal { Text = "<br />" });
                linkButtons.Controls.Add(new LinkButton { Text = "Delete", PostBackUrl = "Customer_Delete.aspx?val="+r.ItemArray[0].ToString() });

                firstName.Text = r.ItemArray[1].ToString();
                lastName.Text = r.ItemArray[2].ToString();
                phoneNumber.Text = r.ItemArray[3].ToString();
                custAddress.Text = r.ItemArray[4].ToString();
                custCity.Text = r.ItemArray[5].ToString();
                custPostal.Text = r.ItemArray[6].ToString();
                emailAddress.Text = r.ItemArray[7].ToString();

                tblRow.Cells.Add(linkButtons);
                tblRow.Cells.Add(firstName);
                tblRow.Cells.Add(lastName);
                tblRow.Cells.Add(phoneNumber);
                tblRow.Cells.Add(custAddress);
                tblRow.Cells.Add(custCity);
                tblRow.Cells.Add(custPostal);
                tblRow.Cells.Add(emailAddress);

                this.tblCustomers.Rows.Add(tblRow);
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