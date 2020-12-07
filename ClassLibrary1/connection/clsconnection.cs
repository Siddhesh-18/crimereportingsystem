using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.connection
{
    public class clsconnection
    {
        public static string connectionstring
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            }
        }
    }
}
