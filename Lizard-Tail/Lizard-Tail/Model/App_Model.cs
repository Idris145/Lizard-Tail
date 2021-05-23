using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lizard_Tail.ConfigurationModule;
using System.Security.Cryptography;
namespace Lizard_Tail.Model
{
    class App_Model
    {
        HomePageModel homePageModel;
        Configuration configuration;
        public App_Model()
        {
            if (File.Exists(Resources.configurationFilePath))
            {
                this.configuration = ConfigurationManager.deserialize(Resources.configurationFilePath);
            }
            else
            {
                this.configuration = new Configuration();
            }
            setPassword("haha");
            ConfigurationManager.updateConfiguration(this.configuration, "123456");
        }
        private void setPassword(string password)
        {
            string passwordCipher = TripleDES.Apply3DES(password);
            this.configuration.PasswordCipher = passwordCipher;
        }
        private void setPrivateKey(string privateKey)
        {
            string privateKeyCipher = TripleDES.Apply3DES(privateKey);
            this.configuration.PrivateKeyCipher = privateKeyCipher;
        }
    }
}
