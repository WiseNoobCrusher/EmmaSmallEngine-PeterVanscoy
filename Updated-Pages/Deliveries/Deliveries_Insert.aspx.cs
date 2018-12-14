using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmmaSmallEngine
{
    public partial class Deliveries_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            var cnnString = global::EmmaSmallEngine.Properties.Settings.Default.EmmaConnectionString;
            var cmd = "INSERT INTO customer VALUES(@FName,@LName,@Phone,@Address,@City,@Postal,@Number,@Date,@Name,@Description)";
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                using (SqlCommand cmds = new SqlCommand(cmd, cnn))
                {
                    cmds.Parameters.AddWithValue("@FName", lblcustFirst.Text);
                    cmds.Parameters.AddWithValue("@LName", lblcustLast.Text);
                    cmds.Parameters.AddWithValue("@Phone", lblcustPhone.Text);
                    cmds.Parameters.AddWithValue("@Address", lblcustAddress.Text);
                    cmds.Parameters.AddWithValue("@City", lblcustCity.Text);
                    cmds.Parameters.AddWithValue("@Postal", lblcustPostal.Text);
                    cmds.Parameters.AddWithValue("@Number", lblordNumber.Text);
                    cmds.Parameters.AddWithValue("@Date", lblordDate.Text);
                    cmds.Parameters.AddWithValue("@Name", lblprodName.Text);
                    cmds.Parameters.AddWithValue("@Description", lblprodDescription.Text);
                    cnn.Open();
                    cmds.ExecuteNonQuery();
                }
            }
            Response.Redirect("~/Deliveries.aspx");
        }
    }
}