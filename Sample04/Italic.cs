using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample04
{
    class Italic : ElementBase
    {
        public Italic()
        {
        }

        public override string ToHTML()
        {
            StringBuilder html = new StringBuilder();

            html.Append("<i>");

            html.Append(base.ToHTML());

            html.Append("</i>");

            return html.ToString();
        }
    }
}