using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Sample05
{
    class ServerCommand : Command
    {
        public ServerCommand(Server server, String command)
        {
            this.server = server;
            this.command = command;
        }
        
        public override void Execute()
        {
            this.server.Operation(this.command);
        }

        private Server server;

        private String command;
    }
}
