using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03
{
    public class DBContext
    {
        public String Name
        {
            set
            {
                Console.WriteLine(" Name : {0}", value);
            }
        }

        public String Host
        {
            set
            {
                Console.WriteLine(" Host : {0}", value);
            }
        }

        public String Port
        {
            set
            {
                Console.WriteLine(" Port : {0}", value);
            }
        }

        public String UserName
        {
            set
            {
                Console.WriteLine(" UserName : {0}", value);
            }
        }

        public String Password
        {
            set
            {
                Console.WriteLine(" Password : {0}", value);
            }
        }

        public bool Connect()
        {
            Console.WriteLine(" Database is connected ");

            return true;
        }

        public void Execute (String sqlCommand)
        {

        }
    }
}
