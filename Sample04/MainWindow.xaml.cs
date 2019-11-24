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


namespace Sample04
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            String _string;

            IElement html = new HTML();

            html.Add(new Bold()
                .Add(new Italic()
                .Add(new Span { Content = "Test" })));
            _string = html.ToHTML();

            this.txtHTML.Text = _string;
            this.wbHTML.NavigateToString(_string);
        }
    }
}
