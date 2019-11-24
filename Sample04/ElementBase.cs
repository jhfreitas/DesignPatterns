using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample04
{
    class ElementBase : IElement
    {
        public ElementBase()
        {
            this.elements = new List<IElement>();
        }

        public IElement Add(IElement element)
        {
            this.elements.Add(element);

            return this;
        }

        public IElement RemoveAll()
        {
            this.elements.Clear();

            return this;
        }

        public virtual String ToHTML()
        {
            StringBuilder html = new StringBuilder();

            //html.Append($"<{this.tag}>");

            foreach (IElement element in this.Elements)
            {
                html.Append(element.ToHTML());
            }

            //html.Append($"</{this.tag}>");

            return html.ToString();
        }

        protected List<IElement> Elements
        {
            get
            {
                return this.elements;
            }
        }

        private List<IElement> elements;
    }
}
