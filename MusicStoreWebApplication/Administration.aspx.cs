using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicStoreWebApplication
{
    public partial class AdministrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            passwordCrypt.ServiceSoapClient client = new passwordCrypt.ServiceSoapClient();

            string accountN = acctName.Text;
            string accountP = acctPassword.Text;

            string encryptPass = client.Encrypt(accountP);

            //check if accountN and encryptPass exist in the DB
            //string decryptPass = client.Decrypt(dbPassword);
            /*if(accountN == dbName && encryptPass == decryptPass)
             * {
             *     //redirect to default page or shopping cart
             * }
             * else
             * {*/
                    AdminWebControl admin;
                    admin = (AdminWebControl)LoadControl("~/AdminWebControl.ascx");
                    //admin.UserName = accountN;
                    //admin.Password = encryptPass;
                    validatePlaceHolder.Controls.Add(admin);
             /* }
            */
        }
    }
}