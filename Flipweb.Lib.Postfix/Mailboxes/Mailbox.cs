using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipweb.Lib.Postfix.Mailboxes
{
    public class Mailbox
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public int quota { get; set; }
        public bool active { get; set; }
        public int id { get; }

        public Mailbox(int id)
        {

        }
    }
}
