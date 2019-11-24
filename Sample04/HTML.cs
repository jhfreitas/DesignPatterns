using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample04
{
    class HTML : ElementBase
    {
        public HTML()
        {
        }

        public override string ToHTML()
        {
            StringBuilder html = new StringBuilder();

            html.Append("<html>");

            html.Append(base.ToHTML());

            html.Append("</html>");

            return html.ToString();
        }
    }
}
