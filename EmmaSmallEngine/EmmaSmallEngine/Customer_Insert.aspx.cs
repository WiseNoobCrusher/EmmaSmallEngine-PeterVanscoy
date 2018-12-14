using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmmaSmallEngine
{
    public partial class Customer_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            var cnnString = global::EmmaSmallEngine.Properties.Settings.Default.EmmaConnectionString;
            var cmd = "INSERT INTO customer VALUES(@FName,@LName,@Phone,@Address,@City,@Postal,@Email)";
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                using (SqlCommand cmds = new SqlCommand(cmd, cnn))
                {
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