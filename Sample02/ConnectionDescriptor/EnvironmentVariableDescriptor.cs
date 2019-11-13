using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample02
{
    class EnvironmentVariableDescriptor : IConnectionDescriptor
    {
        public DescriptorType Type
        {
            get
            {
                return DescriptorType.EnvironmentVariable;
            }
        }

        public String Variable
        {
            get; set;
        }

        public object ConnectionParameter
        {
            get
            {
                return Environment.GetEnvironmentVariable(this.Variable);
            }
        }
    }
}
