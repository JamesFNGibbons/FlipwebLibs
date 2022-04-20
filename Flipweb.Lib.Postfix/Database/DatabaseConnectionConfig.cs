using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipweb.Lib.Postfix.Database
{
    public class DatabaseConnectionConfig
    {
        public string host { get; set; }
        public int port { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string name { get; set; }

        public DatabaseConnectionConfig(string host, int port, string user, string name)
        {
            this.host = host;
            this.port = port;
            this.user = user;
            this.name = name;
        }
    }
}
