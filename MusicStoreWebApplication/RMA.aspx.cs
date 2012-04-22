using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MusicStoreWebApplication
{
    public partial class RMAPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login.aspx");
            }

           
           
            
            RMAWebUserControl rmaCtrl;
            System.Configuration.Configuration rootWebConfig =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/");
            SqlConnection conn = 
                new SqlConnection(rootWebConfig.ConnectionStrings.ConnectionStrings["ApplicationServices"].ToString());

            try {
	            conn.Open();
	            SqlCommand cmd = new SqlCommand();
	            cmd.CommandText = "SELECT * FROM Orders where userName = '" +
                    System.Web.HttpContext.Current.User.Identity.Name
                    + "' ";
	            cmd.Connection = conn;
	            SqlDataReader result = cmd.ExecuteReader(); // Execute the command

                while (result.Read())
                {
                    rmaCtrl = (RMAWebUserControl)LoadControl("~/RMAWebUserControl.ascx");
                    rmaCtrl.orderId = result["id"].ToString();
                    rmaCtrl.dateString = result["placed_at"].ToString();
                    if (result["rmaNumber"].ToString() != "") 
                    {
                        rmaCtrl.submitButton.Text = "RMA Submitted";
                        rmaCtrl.submitButton.Enabled = false;
                    }

                    SqlDataAdapter adapter = 
                        new SqlDataAdapter ("SELECT * FROM OrderItems WHERE OrderId = " + result["id"] ,
                            rootWebConfig.ConnectionStrings.ConnectionStrings["ApplicationServices"].ToString());
                    DataSet ds = new DataSet ();
                    adapter.Fill (ds, "OrderItems");

                    rmaCtrl.itemList.DataSource = ds;
                    rmaCtrl.itemList.DataBind();

                    placeHolder.Controls.Add(rmaCtrl);
                }

                if (Page.IsPostBack)
                {
                    labelTitle.Text = "RMA Submitted";
                    placeHolder.Visible = false;
                }


            }
            catch (SqlException ex) 
            {  
                //  TODO: Handle the exception
            }
            finally { conn.Close (); }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}