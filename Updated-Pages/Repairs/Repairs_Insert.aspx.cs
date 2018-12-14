using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmmaSmallEngine
{
    public partial class Repairs_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            var cnnString = global::EmmaSmallEngine.Properties.Settings.Default.EmmaConnectionString;
            var cmd = "INSERT INTO customer VALUES(@ordNumber,@ordDate, @serordDateIn, @serordDateOut, @serordIssue, @serordWarrenty, @serName, @serDescription, @serPrice, @ordPaid, @Customer)";
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                using (SqlCommand cmds = new SqlCommand(cmd, cnn))
                {
                    cmds.Parameters.AddWithValue("@id", id);
                    cmds.Parameters.AddWithValue("@ordNumber", lblordNumber.Text);
                    cmds.Parameters.AddWithValue("@ordDate", lblordDate.Text);
                    cmds.Parameters.AddWithValue("@serordDateIn", lblserordDateIn.Text);
                    cmds.Parameters.AddWithValue("@serordDateOut", lblserordDateOut.Text);
                    cmds.Parameters.AddWithValue("@serordIssue", lblserordIssue.Text);
                    cmds.Parameters.AddWithValue("@serordWarrenty", lblserordWarrenty.Text);
                    cmds.Parameters.AddWithValue("@serName", lblserName.Text);
                    cmds.Parameters.AddWithValue("@serDescription", lblserDescription.Text);
                    cmds.Parameters.AddWithValue("@serPrice", lblserPrice.Text);
                    cmds.Parameters.AddWithValue("@ordPaid", lblordPaid.Text);
                    cmds.Parameters.AddWithValue("@Customer", lblCustomer.Text);

                    cnn.Open();
                    cmds.ExecuteNonQuery();
                }
            }
            Response.Redirect("~/Customer.aspx");
        }
    }
}