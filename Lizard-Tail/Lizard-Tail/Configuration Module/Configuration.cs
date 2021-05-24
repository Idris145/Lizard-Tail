﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizard_Tail.ConfigurationModule
{

    public class Configuration
    {
        public List<privateKeyConfiguration> privateKeys { get; set; }
        public string password { get; set; }
        public int numberOfEncryptions { get; set; }
    }
}
