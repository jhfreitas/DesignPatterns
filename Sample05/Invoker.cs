using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample05
{
    class Invoker
    {
        public Invoker()
        {
            this.server = new Server();

            this.mementos = new List<CommandMemento>();
        }

        public void SetCommand(String command)
        {
            this.command = new ServerCommand(this.server, command);

            /* Save when, what, where they came from and the content of the message command */
            this.mementos.Add(new CommandMemento(command, DateTime.Now));
        }

        public void ExecuteCommand()
        {
            this.command.Execute();
        }

        public Server Server
        {
            get
            {
                return this.server;
            }
        }

        public List<String> RestoreCommands()
        {
            List<String> commands = new List<String>();

            foreach (CommandMemento memento in this.mementos)
                commands.Add(memento.Command);

            this.mementos.Clear();

            return commands;
        }

        private Server server;
        private ServerCommand command;

        private List<CommandMemento> mementos;
    }
}
