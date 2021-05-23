using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizard_Tail.ConfigurationModule
{

    public class Configuration
    {
        public Configuration()
        {
            mode = Mode.Registration;
        }

        public Mode mode;
        private string _password;
        private string _privateKey;

        public string PasswordCipher { 
            get 
            {
                return _password;
            }
            set
            {
                if (!value.Equals(_password))
                {
                    _password = value;
                }
            }
        }
        public string PrivateKeyCipher
        {
            get
            {
                return _privateKey;
            }
            set
            {
                if (!value.Equals(_privateKey))
                {
                    _privateKey = value;
                }
            }
        }

        public enum Mode
        {
            Registration,
            Login, 
            destroyed
        }
    }
}
