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
            var x = ConfigurationManager.getConfigFromJson(Resources.configurationFilePath);
        }
        
    }
}
