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
        string operatorButtonStr;
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
            if (Display.Text == "0")
            {
                Display.Text = number;
            }
            else
            {
                Display.Text += number;
            } 
        }

        private void deleteFromDisplay() 
        {
            if (!Display.Text.Equals("0"))
            {
                string display = Display.Text.ToString();
                if (display.Length > 1)
                {
                    string newDisplay = display.Remove(display.Length - 1);
                    Display.Text = newDisplay;
                } 
                else
                {
                    Display.Text = "0";
                }
            }
        }
        
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            deleteFromDisplay();
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            operatorButtonStr = Content.ToString();

        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            operatorButtonStr = Content.ToString();
        }

        private void multButton_Click(object sender, RoutedEventArgs e)
        {
            operatorButtonStr = Content.ToString();
        }

        private void divButton_Click(object sender, RoutedEventArgs e)
        {
            operatorButtonStr = Content.ToString();
        }

        private void powButton_Click(object sender, RoutedEventArgs e)
        {
            operatorButtonStr = Content.ToString();
        }

        private void sqrtButton_Click(object sender, RoutedEventArgs e)
        {
            operatorButtonStr = Content.ToString();
        }

        private double calculate(double numero, string operation, double numero2)
        {
            double resultado = 0;
            switch (operation)
            {
                case "+":
                    resultado = numero + numero2;
                    break;

                case "-":
                    resultado = numero - numero;
                    break;

                case "X":
                    resultado = numero * numero2;
                    break;

                case "÷":
                    resultado = numero / numero2;
                    break;

                case "x²":
                    resultado = Math.Pow(numero, numero2);
                    break;

            }
            return resultado;
        }

        private double calculate(int numero, string operation)
        {
            double resultado = 0;
            if (operation.Equals("√x"))
            {
                resultado = Math.Sqrt(numero);
            }
            return resultado;
        }

        private void cButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
        }
    }
}