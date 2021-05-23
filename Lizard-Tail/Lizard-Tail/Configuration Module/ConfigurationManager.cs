using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;
namespace Lizard_Tail.ConfigurationModule
{
    public class ConfigurationManager
    {
        public static void serialize(Configuration configuration, string path)
        {
            var serializer = new XmlSerializer(configuration.GetType());
            using (var writer = XmlWriter.Create(path))
            {
                serializer.Serialize(writer, configuration);
            }
        }
        public static Configuration deserialize(string path)
        {
            var serializer = new XmlSerializer(typeof(Configuration));
            Configuration configuratioin= new Configuration();
            using (var reader = XmlReader.Create(path))
            {
                configuratioin = (Configuration)serializer.Deserialize(reader);
            }
            return configuratioin;
        }
        
        public static void updateConfiguration(Configuration configuration, string password)
        {
            if (File.Exists(Resources.configurationFilePath))
            {
                var lastConfiguration = deserialize(Resources.configurationFilePath);
                var lastPassword = TripleDES.Reverse3DES(lastConfiguration.PasswordCipher);
                if (password.Equals(lastPassword))
                {
                    serialize(configuration, Resources.configurationFilePath);
                    printMessageToConsole("update successful");
                }
            }
            else
            {
                serialize(configuration, Resources.configurationFilePath);
                printMessageToConsole("update successful");
            }
        }
        public static void printMessageToConsole(string message)
        {
            Console.WriteLine($"\n \n \n {message} \n \n \n ");
        }
    }
}
