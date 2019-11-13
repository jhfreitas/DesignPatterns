using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample03
{
    public class DBConnection : ConnectionBuilder
    {
        public DBConnection (ConnectionParameter parameter)
        {
            this.parameter = parameter;
        }

        public override void SetName()
        {
            this.DBContext.Name = this.parameter.Name;
        }

        public override void SetHost()
        {
            this.DBContext.Host = this.parameter.Host;
        }

        public override void SetPort()
        {
            this.DBContext.Port = this.parameter.Port;
        }

        public override void SetUserName()
        {
            this.DBContext.UserName = this.parameter.UserName;
        }

        public override void SetPassword()
        {
            this.DBContext.Password = this.parameter.Password;
        }

        public override bool Connect()
        {
            return this.DBContext.Connect();
        }

        private ConnectionParameter parameter;
    }
}
