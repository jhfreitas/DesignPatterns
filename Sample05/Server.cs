using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace Sample05
{
    class Server
    {
        public Server ()
        {
            this.neighbors = new List<Server>();
            this.serializer = new JavaScriptSerializer();

            this.commands = new Dictionary<String, Command>();

            this.commands.Add("search", this.SearchCommand);
            this.commands.Add("upload", this.UploadCommand);
            this.commands.Add("execute", this.ExecuteCommand);            
            this.commands.Add("neighbors", this.NeighborsCommand);
        }

        public void Operation(String command)
        {
            Command method;

            /* Parse the command received */
            dynamic result = serializer.DeserializeObject((String)command);

            this.commandReceived = command;

            if (this.commands.TryGetValue(result["command"], out method) == true)
            {                
                method();
            }
        }

        public List<Server> Neighbors
        {
            get
            {
                return this.neighbors;
            }

            set
            {
                this.neighbors = value;
            }
        }

        private void SearchCommand()
        {
            Console.WriteLine("Search Command Received");
        }

        private void UploadCommand()
        {
            Console.WriteLine("Update Command Received");
        }

        private void ExecuteCommand()
        {
            Console.WriteLine("Execute Command Received");
        }

        private void NeighborsCommand()
        {
            Console.WriteLine("Neighbors Command Received");

            dynamic result = serializer.DeserializeObject((String)commandReceived);
            Int32 depth = Convert.ToInt32(result["depth"]);

            if (depth > 0)
            {
                result["depth"] = Convert.ToString( depth - 1);

                String json = this.serializer.Serialize(result);

                foreach (Server server in this.neighbors)
                {
                    server.Operation(json);
                }
            }
        }

        private delegate void Command();

        private List<Server> neighbors;
        private Dictionary<String, Command> commands;
        private JavaScriptSerializer serializer;
        private String commandReceived;
    }
}
