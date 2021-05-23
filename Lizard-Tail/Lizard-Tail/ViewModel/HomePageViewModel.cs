using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizard_Tail.ViewModel
{
    class HomePageViewModel
    {
        private string _loginButtonText;

        public string LoginButtonText
        {
            get
            {
                return _loginButtonText;
            }
            set
            {
                if (!value.Equals(_loginButtonText))
                {
                    this._loginButtonText = value;
                }
            }

        }
    }
}
