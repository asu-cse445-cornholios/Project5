using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Web.Security;

namespace MusicStoreWebApplication
{
    public partial class AdminWebControl : System.Web.UI.UserControl
    {
        private int flag;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                LoginPanel.Visible = true;
                DeleteUser.Visible = false;
            }
            else if (flag == 1)
            {
                DeleteUser.Visible = true;
                LoginPanel.Visible = false;
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            passwordCrypt.ServiceSoapClient client = new passwordCrypt.ServiceSoapClient();

            string name = acctName.Text;
            string pass = acctPassword.Text;

            string nameSettings = WebConfigurationManager.AppSettings["name"];
            string passSettings = WebConfigurationManager.AppSettings["password"];

            string decryptPass = client.Decrypt(passSettings);

            if (name == nameSettings && pass == decryptPass)
            {
                getUsers();
            }
            else
            {
                flag = 0;
                LoginPanel.Visible = true;
                DeleteUser.Visible = false;

                Label.Text = "Not correct user name and password";
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            string delete = deleteBox.Text;
            Membership.DeleteUser(delete);

            outputLabel.Text = "";
            deleteBox.Text = "";

            getUsers();

        }

        protected void getUsers()
        {
            flag = 1;
            DeleteUser.Visible = true;
            LoginPanel.Visible = false;

            MembershipUserCollection members = Membership.GetAllUsers();

            foreach (MembershipUser member in members)
            {
                outputLabel.Text += member.UserName + "<br/>\n";
            }
        }
    }
}