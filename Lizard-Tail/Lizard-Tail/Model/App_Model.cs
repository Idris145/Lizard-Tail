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
            var realConfig = ConfigurationManager.getConfigFromJson(Resources.configurationFilePath);
            /*var encryptedConfig = new Configuration();
            encryptedConfig.password = TripleDES.Apply3DES(realConfig.password);
            foreach (var privateKey in realConfig.privateKeys)
            {
                var encryptedKey = TripleDES.Apply3DES(privateKey.privateKey);
                var encryptedCurrency = TripleDES.Apply3DES(privateKey.currency);
                var pkc = new privateKeyConfiguration();
                pkc.currency = encryptedCurrency;
                pkc.privateKey = encryptedKey;
                encryptedKeys.Add(pkc);
            }
            encryptedConfig.privateKeys = encryptedKeys;*/
        }
        
    }
}
