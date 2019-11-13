using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    class VariableConnection : IConnection
    {
        public ConnectionParameter GetParameter(IConnectionDescriptor descriptor)
        {
            throw new NotImplementedException();
        }
    }
}
