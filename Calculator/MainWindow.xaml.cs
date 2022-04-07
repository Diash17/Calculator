using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EventManager.RegisterClassHandler(typeof(Button), Button.ClickEvent, new RoutedEventHandler(ButtonMain));
        }

        private void ButtonMain(object sender, RoutedEventArgs eventArgs)
        {
            Button B = (Button)sender;

            switch (B.Content)
            {
                case "=":
                    string value = new DataTable().Compute(Screen.Text, null).ToString();
                    Screen.Text = value;
                    break;
                case "AC":
                    Screen.Text = "";
                    break;
                default:
                    Screen.Text += B.Content;
                    break;
            }
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}