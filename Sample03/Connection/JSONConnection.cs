using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace Sample03
{
    public class JSONConnection : IConnection
    {
        public JSONConnection(IConnectionDescriptor descriptor)
        {
            this.descriptor = (JSONDescriptor)descriptor;
        }

        public ConnectionParameter GetParameter()
        {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            dynamic result = serializer.DeserializeObject((String)this.descriptor.ConnectionParameter);

            this.connection = new ConnectionParameter();

            this.connection.Name = result["DatabaseName"];
            this.connection.Host = result["Host"];
            this.connection.Port = result["Port"];
            this.connection.UserName = result["UserName"];
            this.connection.Password = result["Password"];

            return this.connection;
        }

        private ConnectionParameter connection;
        private JSONDescriptor descriptor;
    }
}
