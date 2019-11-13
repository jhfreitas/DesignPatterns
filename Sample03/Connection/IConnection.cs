using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample03
{
    //class ConnectionFactory
    //{
    //    public static IDatabaseConnection Create(Type type)
    //    {
    //        IDatabaseConnection repository = null;

    //        switch (type)
    //        {
    //            case ConnectionFactory.Type.POJO:
    //                break;

    //            case ConnectionFactory.Type.JSON:
    //                repository = new JSONConnection();
    //                break;

    //            case ConnectionFactory.Type.Record:
    //                break;
    //        }

    //        return repository;
    //    }

    //private static IDatabaseConnection repository;
    //}

    public interface IConnection
    {
        ConnectionParameter GetParameter();
    }
}
