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
using SalesDatasets.DeliveryDatasetTableAdapters;

namespace EmmaSmallEngine
{
    public partial class Deliveries : System.Web.UI.Page
    {
        private static DeliveryDataset dsDelivery = new DeliveryDataset();

        protected void Page_Load(object sender, EventArgs e)
        {
            deliveryTableAdapter daDelivery = new deliveryTableAdapter();

            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Login.aspx");
            }

            daDelivery.Update(dsDelivery);
            daDelivery.Fill(dsDelivery.delivery);

            foreach (DataRow r in dsDelivery.delivery)
            {
                TableRow tblRow = new TableRow();

                TableCell linkButtons = new TableCell();
                TableCell custfirst = new TableCell();
                TableCell custLast = new TableCell();
                TableCell custPhone = new TableCell();
                TableCell custAddress = new TableCell();
                TableCell custCity = new TableCell();
                TableCell custPostal = new TableCell();
                TableCell ordNumber = new TableCell();
                TableCell ordDate = new TableCell();
                TableCell prodName = new TableCell();
                TableCell prodDescription = new TableCell();

                linkButtons.Controls.Add(new LinkButton { Text = "Edit", PostBackUrl = "Deliveries_Edit.aspx?val=" + r.ItemArray[0].ToString() });
                linkButtons.Controls.Add(new Literal { Text = "<br />" });
                linkButtons.Controls.Add(new LinkButton { Text = "Delete", PostBackUrl = "Deliveries_Delete.aspx?val=" + r.ItemArray[0].ToString() });

                custfirst.Text = r.ItemArray[1].ToString();
                custLast.Text = r.ItemArray[2].ToString();
                custPhone.Text = r.ItemArray[3].ToString();
                custAddress.Text = r.ItemArray[4].ToString();
                custCity.Text = r.ItemArray[5].ToString();
                custPostal.Text = r.ItemArray[6].ToString();
                ordNumber.Text = r.ItemArray[7].ToString();
                ordDate.Text = r.ItemArray[8].ToString();
                prodName.Text = r.ItemArray[9].ToString();
                prodDescription.Text = r.ItemArray[10].ToString();

                tblRow.Cells.Add(linkButtons);
                tblRow.Cells.Add(custfirst);
                tblRow.Cells.Add(custLast);
                tblRow.Cells.Add(custPhone);
                tblRow.Cells.Add(custAddress);
                tblRow.Cells.Add(custCity);
                tblRow.Cells.Add(custPostal);
                tblRow.Cells.Add(ordNumber);
                tblRow.Cells.Add(ordDate);
                tblRow.Cells.Add(prodName);
                tblRow.Cells.Add(prodDescription);

                this.tblDeliveries.Rows.Add(tblRow);
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