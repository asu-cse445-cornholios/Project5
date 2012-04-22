using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystemLibrary
{
    public class AdminLib
    {
        public string decryption(string passSettings)
        {
            passwordCrypt.ServiceSoapClient client = new passwordCrypt.ServiceSoapClient();
            string decryptPass = client.Decrypt(passSettings);

            return decryptPass;
        }

        public string encryption(string passSettings)
        {
            passwordCrypt.ServiceSoapClient client = new passwordCrypt.ServiceSoapClient();
            string encryptPass = client.Encrypt(passSettings);

            return encryptPass;
        }
    }
}
