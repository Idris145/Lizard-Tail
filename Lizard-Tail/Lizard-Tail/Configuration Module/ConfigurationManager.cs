using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;
using Newtonsoft.Json;
namespace Lizard_Tail.ConfigurationModule
{
    public class ConfigurationManager
    {


        public static Configuration getConfigFromJson(string path)
        {

            Configuration configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(Resources.configurationFilePath));
            
            foreach (var x in configuration.privateKeys)
            {
                printMessageToConsole(x.currency);
                printMessageToConsole(x.privateKey);
            }

            return configuration;

        }
        
        public static string encryptConfiguration(Configuration configuration)
        {
            return "";
        }
        public static void printMessageToConsole(string message)
        {
            Console.WriteLine($"\n \n \n {message} \n \n \n ");
        }
    }
}
