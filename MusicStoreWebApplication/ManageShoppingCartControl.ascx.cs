using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderSystemLibrary;

namespace MusicStoreWebApplication
{
    public partial class ManageShoppingCartControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShoppingCartContext.CreateCart(Context.User.Identity.Name);
                var newItem = Request.QueryString["Add"];
                if (!String.IsNullOrWhiteSpace(newItem))
                {
                    ShoppingCartContext.AddNewItem(Context.User.Identity.Name, HttpUtility.UrlDecode(newItem), 1);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var success= ShoppingCartContext.SubmitOrder(Context.User.Identity.Name);
            lblSuccess.Text = success ? "Success" : "Failed";
        }

        protected void ShoppingCartLinqDataSource_ContextCreating(object sender, LinqDataSourceContextEventArgs e)
        {
            e.ObjectInstance = new ShoppingCartContext(Context.User.Identity.Name);
        }
    }
}