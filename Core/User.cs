using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class User
    {
        static private string USERNAME;

        public void setUSERNAME(string user)
        {
            USERNAME = user;
        }
        public string getUSERNAME()
        {
            return USERNAME;
        }
    }
}
