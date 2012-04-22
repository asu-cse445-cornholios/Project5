using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicStoreWebApplication
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                NavigationMenu.Items.Remove(NavigationMenu.FindItem("RMA"));
                NavigationMenu.Items.Remove(NavigationMenu.FindItem("ShoppingCart"));
            }
        }
    }
}
