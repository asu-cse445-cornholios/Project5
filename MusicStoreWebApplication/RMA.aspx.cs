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

            if (Page.IsPostBack)
            {
                labelTitle.Text = "RMA Submitted";
                placeHolder.Controls.Clear();

            }
            else
            {
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
                        rmaCtrl.orderId = (string)result["id"];
                        rmaCtrl.dateString = (string)result["placed_at"];

                        SqlDataAdapter adapter = 
                            new SqlDataAdapter ("SELECT * FROM OrderItems WHERE OrderId = " + (string)result["id"] + "' ",
                                rootWebConfig.ConnectionStrings.ConnectionStrings["ApplicationServices"].ToString());
                        DataSet ds = new DataSet ();
                        adapter.Fill (ds, "OrderItems");

                        rmaCtrl.itemList.DataSource = ds;
                        rmaCtrl.itemList.DataBind();
                    }


                }
                catch (SqlException ex) 
                {  
                    //  TODO: Handle the exception
                }
                finally { conn.Close (); }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}