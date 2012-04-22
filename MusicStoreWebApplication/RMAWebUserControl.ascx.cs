using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderSystemLibrary;

namespace MusicStoreWebApplication
{
    public partial class RMAWebUserControl : System.Web.UI.UserControl
    {
        public string orderId 
        { 
            get { return Label1.Text; }
            set { Label1.Text = value; }
        }

        public string dateString 
        { 
            get { return Label2.Text; }
            set { Label2.Text = value; }
        }

        public GridView itemList 
        {
            get { return GridView1; }
            set { GridView1 = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += Button1_Click;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OrderSystemLibrary.RMASvc.RMAticket ticket =
                RMALib.submitRMA(this.orderId, System.Web.HttpContext.Current.User.Identity.Name);
            System.Configuration.Configuration rootWebConfig =
                    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/");
            SqlConnection conn = 
                    new SqlConnection(rootWebConfig.ConnectionStrings.ConnectionStrings["ApplicationServices"].ToString());

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = 
                    String.Format("UPDATE Orders SET rmaNumber = '{0}' WHERE id = {1}",
                    ticket.RMANumber, orderId.Trim());
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); // Execute the command
            }
            catch (SqlException ex)
            {
                //  TODO: Handle the exception
            }
            finally { conn.Close(); }
        }
    }
}