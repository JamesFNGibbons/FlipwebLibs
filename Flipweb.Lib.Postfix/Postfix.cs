using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flipweb.Lib.Postfix.Database;

namespace Flipweb.Lib.Postfix
{
    public class Postfix
    {
        public Postfix(DatabaseConnectionConfig config)
        {
            // establish new connection pool to the database
            DatabaseConnection connection = new DatabaseConnection(config);

        }
    }
}
