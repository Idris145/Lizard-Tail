using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizard_Tail.ConfigurationModule
{

    public class Configuration
    {
        public byte[] password { get; set; }
        public byte[] numberOfEncryptions { get; set; }
        public List<(byte[], byte[])> privateKeys { get; set; }
    }
}
