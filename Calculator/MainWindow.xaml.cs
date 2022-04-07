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
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            Screen.Text += str;
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            string str = ".";
            Screen.Text += str;
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            string str = "0";
            Screen.Text += str;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string str = "1";
            Screen.Text += str;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            string str = "2";
            Screen.Text += str;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            string str = "3";
            Screen.Text += str;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            string str = "4";
            Screen.Text += str;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            string str = "5";
            Screen.Text += str;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            string str = "6";
            Screen.Text += str;
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            string str = "7";
            Screen.Text += str;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            string str = "8";
            Screen.Text += str;
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            string str = "9";
            Screen.Text += str;
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            Screen.Text = str;
        }

        private void ButtonMulti_Click(object sender, RoutedEventArgs e)
        {
            string str = "*";
            Screen.Text += str;
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            string str = "/";
            Screen.Text += str;
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            string str = "-";
            Screen.Text += str;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            string str = "+";
            Screen.Text += str;
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            string value = new DataTable().Compute(Screen.Text, null).ToString();
            Screen.Text = value;
        }

        private void ButtonPercent_Click(object sender, RoutedEventArgs e)
        {
            string str = "%";
            Screen.Text += str;
        }

        //private void ButtonSignNegative_Click(object sender, RoutedEventArgs e)
        //{
           
        //}
    }
}