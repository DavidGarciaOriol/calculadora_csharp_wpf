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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void number0Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number0Button.Content.ToString());
        }

        private void number1Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number1Button.Content.ToString());
        }

        private void number2Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number2Button.Content.ToString());
        }

        private void number3Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number3Button.Content.ToString());
        }

        private void number4Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number4Button.Content.ToString());
        }

        private void number5Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number5Button.Content.ToString());
        }

        private void number6Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number6Button.Content.ToString());
        }

        private void number7Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number7Button.Content.ToString());
        }

        private void number8Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number8Button.Content.ToString());
        }

        private void number9Button_Click(object sender, RoutedEventArgs e)
        {
            addToDisplay(number9Button.Content.ToString());
        }

        private void addToDisplay(string number)
        {
            if (Display.Content.ToString() == "0")
            {
                Display.Content = "";
            }

            Display.Content += number;
            
        }
    }
}