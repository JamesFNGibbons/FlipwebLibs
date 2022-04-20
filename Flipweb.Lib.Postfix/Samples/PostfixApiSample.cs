using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flipweb.Lib.Postfix;
using Flipweb.Lib.Postfix.Database;

namespace Flipweb.Lib.Postfix.Samples
{
    class PostfixApiSample
    {
        string databaseName = "";
        string databaseHost = "";
        int databasePort = 100;
        string databaseUser = "";
        string databasePassword = ""; 

        public PostfixApiSample()
        {
            DatabaseConnectionConfig postfixDbConfig = new DatabaseConnectionConfig(
            databaseHost,
            databasePort,
            databaseUser,
            databasePassword
        );
            Postfix postfix = new Postfix(postfixDbConfig);
        }
    }
}
