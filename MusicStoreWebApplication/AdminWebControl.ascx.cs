using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicStoreWebApplication
{
    public partial class AdminWebControl: System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string UserName
        {
            get { return user.Text; }
            set { user.Text = value; }
        }

        public string Password
        {
            get { return pass.Text; }
            set { pass.Text = value; }
        }

        public string Confirm
        {
            get { return confirmPass.Text; }
            set { confirmPass.Text = value; }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string createUser = user.Text;
            string createPassword = pass.Text;
            string createConfirm = confirmPass.Text;

            //add createUser, createPassword, createConfirm to DB
            //add the type too - NonAdmin

            Label1.Text = "New User Created";
            //redirect to default page
        }
    }
}