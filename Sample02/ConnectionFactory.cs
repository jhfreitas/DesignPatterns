using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample02
{
    public class ConnectionFactory
    {
        public static IConnection GetInstance (IConnectionDescriptor descriptor)
        {
            if (ConnectionFactory.connection == null)
            {
                switch (descriptor.Type)
                {
                    case DescriptorType.JSON:
                        ConnectionFactory.connection = new JSONConnection(descriptor);
                        break;

                    case DescriptorType.EnvironmentVariable:
                        ConnectionFactory.connection = new EnvironmentVariableConnection(descriptor);
                        break;

                    default:
                        ConnectionFactory.connection = null;
                        break;
                }
            }
            
            return ConnectionFactory.connection;
        }

        private static IConnection connection;
    }
}
