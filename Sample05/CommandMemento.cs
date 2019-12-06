using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample05
{
    class CommandMemento
    {
        public CommandMemento(String command, DateTime dateTime)
        {
            this.command = command;
            this.dateTime = dateTime;
        }

        public String Command
        {
            get
            {
                return this.command;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
        }

        private String command;
        private DateTime dateTime;
    }
}
