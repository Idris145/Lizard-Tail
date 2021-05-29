using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;
using Newtonsoft;
using Newtonsoft.Json.Linq;
namespace Lizard_Tail.ConfigurationModule
{
    public class ConfigurationManager
    {


        public static Configuration getConfigFromJson(string path)
        {
            var configuration = new Configuration();
            dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(File.ReadAllText(Resources.configurationFilePath));


            foreach (JProperty x in (JToken)obj)
            { // if 'obj' is a JObject
                string name = x.Name;
                if (name.Equals("password"))
                {
                    string value = (string)x.Value;
                    configuration.password = TripleDES.Apply3DES(value);
                }
                else if (name.Equals("numberOfEncryptions"))
                {
                    string value = (string)x.Value;
                    configuration.numberOfEncryptions = TripleDES.Apply3DES(value);
                }

                if (name.Equals("privateKeys"))
                {
                    List<(byte[], byte[])> privateKeys = new List<(byte[], byte[])>();
                    foreach (var y in x.Value)
                    {
                        byte[] currency = null;
                        byte[] privateKey = null;
                        foreach (JProperty z in  y)
                        {
                             
                            if (z.Name.Equals("currency"))
                            {
                                currency = TripleDES.Apply3DES((string)z.Value);
                                // configuration.password = TripleDES.Apply3DES(value);
                            }
                            else if (z.Name.Equals("privateKey"))
                            {
                                privateKey = TripleDES.Apply3DES((string)z.Value);
                                // configuration.numberOfEncryptions = TripleDES.Apply3DES(value);
                            }
                        }
                        privateKeys.Add((currency, privateKey));
                    }
                    configuration.privateKeys = privateKeys;
                }
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
