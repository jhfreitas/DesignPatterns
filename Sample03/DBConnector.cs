using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample03
{
    public class DBConnector
    {
        public DBConnector()
        {
        }

        public bool Construct(ConnectionBuilder builder)
        {
            builder.SetHost();
            builder.SetName();
            builder.SetPassword();
            builder.SetPort();
            builder.SetUserName();

            return builder.Connect();
        }
    }
}
