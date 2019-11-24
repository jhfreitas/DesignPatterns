using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample04
{
    class Bold : ElementBase
    {
        public Bold()
        {
        }

        public override string ToHTML()
        {
            StringBuilder html = new StringBuilder();

            html.Append("<b>");

            html.Append(base.ToHTML());

            html.Append("</b>");

            return html.ToString();
        }
    }
}
