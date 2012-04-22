using System;
using System.Collections.Generic;
using System.Data.SqlClient ;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MusicStoreWebApplication
{
    public class Global : System.Web.HttpApplication
    {
        static int visitorCount;

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

            visitorCount = 0;
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

            System.Configuration.Configuration rootWebConfig =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/");
            SqlConnection conn =
                new SqlConnection(rootWebConfig.ConnectionStrings.ConnectionStrings["ApplicationServices"].ToString());

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = String.Format("INSERT INTO  Visits VALUES ({0})",
                    visitorCount);

            cmd.Connection = conn;
            cmd.ExecuteNonQuery(); // Execute the command

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            Response.Redirect("~/ErrorPage.aspx");
        }

        void Session_OnStart(object sender, EventArgs e)
        {
            visitorCount++;

        }

        void Session_OnEnd(object sender, EventArgs e)
        {
            
        }

    }
}
