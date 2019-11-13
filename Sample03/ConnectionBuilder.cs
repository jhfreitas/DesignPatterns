using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample03
{
    public abstract class ConnectionBuilder
    {
        public ConnectionBuilder()
        {
            this.context = new DBContext();
        }

        public DBContext DBContext
        {
            get
            {
                return this.context;
            }
        }

        public abstract void SetName();

        public abstract void SetHost();

        public abstract void SetPort();

        public abstract void SetUserName();

        public abstract void SetPassword();

        public abstract bool Connect();

        private DBContext context;
    }
}
