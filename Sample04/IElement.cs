using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample04
{
    interface IElement
    {
        IElement Add(IElement element);

        IElement RemoveAll();

        String ToHTML();
    }

    //abstract class IElement
    //{
    //    public abstract IElement Add(IElement element);

    //    public abstract IElement RemoveAll();

    //    public abstract String ToHTML();

    //    //protected abstract void TagStarting();
    //    //protected abstract void TagEnding();
    //}
}
