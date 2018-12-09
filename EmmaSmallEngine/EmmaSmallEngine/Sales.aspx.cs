using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SalesDatasets;
using SalesDatasets.SalesDatasetTableAdapters;


namespace EmmaSmallEngine
{
    public partial class Sales : System.Web.UI.Page
    {
        private static SalesDataset dsSales = new SalesDataset();

        static Sales()
        {
            customerTableAdapter daCustomer = new customerTableAdapter();
            try
            {
                daCustomer.Fill(dsSales.customer);
            }
            catch (Exception ex) { }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Login.aspx");
            }

            if (this.IsPostBack) return;

            this.ddlCustomers.Items.Add("Pick a Customer...");
            this.ddlCustomers.Items[0].Attributes.Add("style", "color:gray");
            this.ddlCustomers.Items[0].Attributes.Add("disabled", "disabled");
            this.ddlCustomers.Items[0].Selected = true;

            foreach (DataRow r in dsSales.customer)
            {
                this.ddlCustomers.Items.Add(r.ItemArray[1].ToString());
            }
        }

        protected void custSubmit_Click(object sender, EventArgs e)
        {
            var cnt = 0;

            if (cnt >= 1)
            {
                this.tblCustInfo.Rows.RemoveAt(1);
                for (int i=1; i<3; i++)
                {
                    this.tblOrders.Rows.RemoveAt(i);
                }
            }

            custinfoTableAdapter daCustInfo = new custinfoTableAdapter();
            ordersTableAdapter daOrders = new ordersTableAdapter();
            try
            {
                if (this.ddlCustomers.SelectedValue != "Pick a Customer...")
                {
                    daCustInfo.Fill(dsSales.custinfo, ddlCustomers.SelectedIndex);
                    this.tblCustInfoTableHeadings.Visible = this.tblCustInfo.Visible = this.lblCustInfo.Visible = true;

                    daOrders.Fill(dsSales.orders, ddlCustomers.SelectedIndex);
                    this.tblOrdersTableHeadings.Visible = this.tblOrders.Visible = this.lblOrders.Visible = true;

                    foreach (DataRow r in dsSales.custinfo)
                    {
                        TableRow tblRow = new TableRow();

                        TableCell emailAddress = new TableCell();
                        TableCell postalCode = new TableCell();
                        TableCell custCity = new TableCell();
                        TableCell custAddress = new TableCell();
                        TableCell phoneNumber = new TableCell();
                        TableCell custModel = new TableCell();
                        TableCell custSerial = new TableCell();
                        TableCell custType = new TableCell();

                        emailAddress.Text = r.ItemArray[0].ToString();
                        postalCode.Text = r.ItemArray[1].ToString();
                        custCity.Text = r.ItemArray[2].ToString();
                        custAddress.Text = r.ItemArray[3].ToString();
                        phoneNumber.Text = r.ItemArray[4].ToString();
                        custModel.Text = r.ItemArray[5].ToString();
                        custSerial.Text = r.ItemArray[6].ToString();
                        custType.Text = r.ItemArray[7].ToString();

                        tblRow.Cells.Add(emailAddress);
                        tblRow.Cells.Add(postalCode);
                        tblRow.Cells.Add(custCity);
                        tblRow.Cells.Add(custAddress);
                        tblRow.Cells.Add(phoneNumber);
                        tblRow.Cells.Add(custModel);
                        tblRow.Cells.Add(custSerial);
                        tblRow.Cells.Add(custType);

                        this.tblCustInfo.Rows.Add(tblRow);
                    }

                    foreach (DataRow r in dsSales.orders)
                    {
                        TableRow tblRow = new TableRow();

                        TableCell orderNumber = new TableCell();
                        TableCell orderDate = new TableCell();
                        TableCell orderPrice = new TableCell();

                        orderNumber.Text = r.ItemArray[1].ToString();
                        orderDate.Text = r.ItemArray[2].ToString();
                        orderPrice.Text = r.ItemArray[3].ToString();

                        tblRow.Cells.Add(orderNumber);
                        tblRow.Cells.Add(orderDate);
                        tblRow.Cells.Add(orderPrice);

                        this.tblOrders.Rows.Add(tblRow);
                    }
                    cnt++;
                }
                refreshCustomerDDL();
            }
            catch (Exception ex) { }
        }

        private void refreshCustomerDDL()
        {
            this.ddlCustomers.Items[0].Attributes.Add("style", "color:gray");
            this.ddlCustomers.Items[0].Attributes.Add("disabled", "disabled");
        }
    }
}