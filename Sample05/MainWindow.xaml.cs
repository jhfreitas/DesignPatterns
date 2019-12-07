using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sample05
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<String> list = new List<string>()
            {
                @"{ command: ""search"", keywords: ""music mp3"", destination: ""100.22.11.25:8888"" }",
                @"{ command: ""upload"", filename: ""music.mp3"", content: ""[byte array]"" }",
                @"{ command: ""execute"", script: ""music.sh"" }",
                @"{ command: ""neighbors"", depth: ""2"", destination: ""90.12.50.21:8975"" }"
            };

            this.invoker = new Invoker();
            this.neighbor = new Server();
            this._neighbor = new Server();

            this.invoker.Server.Neighbors.Add(this.neighbor);
            this.neighbor.Neighbors.Add(this._neighbor);

            foreach (String item in list)
            {
                this.invoker.SetCommand(item);

                this.invoker.ExecuteCommand();
            }

            List<CommandMemento> commands = this.invoker.RestoreCommands();

            this.dgCommand.ItemsSource = commands;
        }

        private Invoker invoker;
        private Server neighbor;
        private Server _neighbor;
    }
}
