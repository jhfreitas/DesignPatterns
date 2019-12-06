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

            this.commands = new Dictionary<String, Command>();

            this.commands.Add("search", this.SearchCommand);
            this.commands.Add("upload", this.UploadCommand);
            this.commands.Add("execute", this.ExecuteCommand);            
            this.commands.Add("neighbors", this.NeighborsCommand);
        }

        public void Operation(String command)
        {
            /* Parse the command received */
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            dynamic result = serializer.DeserializeObject((String)command);
            
            Command method;

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
        }

        private void UploadCommand()
        {
        }

        private void ExecuteCommand()
        {
        }

        private void NeighborsCommand()
        {
            /* Apply Iterator Pattern */
            this.neighbors.Clear();
        }

        private delegate void Command();

        private List<Server> neighbors;
        private Dictionary<String, Command> commands;
    }
}
