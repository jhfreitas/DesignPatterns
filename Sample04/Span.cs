using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample04
{
    class Span : ElementBase
    {
        public Span ()
        {
        }

        public String Content
        {
            get
            {
                return this.content;
            }

            set
            {
                this.content = value;
            }
        }

        public override string ToHTML()
        {
            StringBuilder html = new StringBuilder();

            html.Append("<span>");

            html.Append(base.ToHTML());

            html.Append(this.content);

            html.Append("</span>");

            return html.ToString();
        }

        private String content;
    }
}
