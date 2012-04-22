using System;
using System.Collections.Generic;
using System.Linq;
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RMALib.submitRMA(this.orderId, System.Web.HttpContext.Current.User.Identity.Name);
        }
    }
}