using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample02
{
    //public interface IDataReader
    //{
    //    String Create();
    //}

    public enum DescriptorType
    {
        POJO,
        JSON,
        Record,
        EnvironmentVariable
    }

    public interface IConnectionDescriptor
    {
        DescriptorType Type
        {
            get;
        }

        object ConnectionParameter
        {
            get;
        }
    }
}
