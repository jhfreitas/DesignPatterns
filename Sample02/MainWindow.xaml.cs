using System;
using System.Collections.Generic;
using System.IO;
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


namespace Sample02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //String json = @"{ ""DatabaseName"" : ""Oracle"", ""Host"" : ""192.168.0.1"", ""Port"" : ""8080"", ""UserName"": ""jorge.freitas"", ""Password"": ""123456"" }";
            // Create a new file     
            using (FileStream fs = File.Create("JSON.json"))
            {
                // Add some text to file    
                Byte[] json = new UTF8Encoding(true).GetBytes(@"{ ""DatabaseName"" : ""Oracle"", ""Host"" : ""192.168.0.1"", ""Port"" : ""8080"", ""UserName"": ""jorge.freitas"", ""Password"": ""123456"" }");
                fs.Write(json, 0, json.Length);
            }

            IConnection connection;
            ConnectionParameter parameter;

            /* Specific Descriptor */
            JSONDescriptor descriptor = new JSONDescriptor();
            descriptor.Path = "JSON.json";

            connection = ConnectionFactory.GetInstance(descriptor);

            parameter = connection.GetParameter();

            /* Specific Descriptor */
            Environment.SetEnvironmentVariable("CONNECTION", "DatabaseName:Oracle;Host: 192.168.0.1");

            EnvironmentVariableDescriptor _descriptor = new EnvironmentVariableDescriptor();
            _descriptor.Variable = "CONNECTION";

            connection = ConnectionFactory.GetInstance(_descriptor);
            parameter = connection.GetParameter();
        }
    }
}
