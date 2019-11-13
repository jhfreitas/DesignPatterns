using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample02
{
    class EnvironmentVariableConnection : IConnection
    {
        public EnvironmentVariableConnection(IConnectionDescriptor descriptor)
        {
            this.descriptor = (EnvironmentVariableDescriptor)descriptor;
        }

        public ConnectionParameter GetParameter()
        {   
            String value = (String)this.descriptor.ConnectionParameter;
            value = value.Trim();

            this.connection = new ConnectionParameter();

            //String[] list = value.Split(';');

            var dictionary = value.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(part => part.Split(':'))
                .ToDictionary(split => split[0], split => split[1]);
            
            dictionary.TryGetValue("DatabaseName", out value);
            this.connection.Name = value;
            dictionary.TryGetValue("Host", out value);
            this.connection.Host = value;
            dictionary.TryGetValue("Port", out value);
            this.connection.Port = value;
            dictionary.TryGetValue("UserName", out value);
            this.connection.UserName = value;
            dictionary.TryGetValue("Password", out value);
            this.connection.Password = value;

            return this.connection;
        }

        private ConnectionParameter connection;
        private EnvironmentVariableDescriptor descriptor;
    }
}
