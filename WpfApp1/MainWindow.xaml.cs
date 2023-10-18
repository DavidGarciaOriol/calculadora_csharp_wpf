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
        string previousInput = "";

        string operatorButtonStr;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonHover(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = new SolidColorBrush(Color.FromRgb(179,179,179));
        }

        private void ButtonLeaveEqual(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = new SolidColorBrush(Color.FromRgb(99, 174, 224));
        }

        private void ButtonLeave(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = new SolidColorBrush(Color.FromRgb(87, 86, 86));
        }

        private void ButtonLeaveDark(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = new SolidColorBrush(Color.FromRgb(68,68,68));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;

            string buttonText = button.Content.ToString();

            switch (buttonText)
            {
                case "=":
                    
                    break;
                case ",":
                    
                    break;
                case "0":
                    addToDisplay(buttonText);
                    break;
                case "1":
                    addToDisplay(buttonText);
                    break;
                case "2":
                    addToDisplay(buttonText);
                    break;
                case "3":
                    addToDisplay(buttonText);
                    break;
                case "4":
                    addToDisplay(buttonText);
                    break;
                case "5":
                    addToDisplay(buttonText);
                    break;
                case "6":
                    addToDisplay(buttonText);
                    break;
                case "7":
                    addToDisplay(buttonText);
                    break;
                case "8":
                    addToDisplay(buttonText);
                    break;
                case "9":
                    addToDisplay(buttonText);
                    break;
                case "+/-":
                    if (Display.Text != "0")
                    {
                        if (Display.Text.StartsWith("-"))
                        {
                            Display.Text = Display.Text.Substring(1);
                        }
                        else
                        {
                            Display.Text = "-" + Display.Text;
                        }
                    }
                    break;
                case "⌫":
                    deleteFromDisplay();
                    break;
                case "C":
                    Display.Text = "0";
                    break;
                case "CC":
                    Display.Text = "0";
                    break;

                case "+":

                    break;
                case "-":
                    break;
                case "X":
                    break;
                case "÷":
                    break;
                case "x²":
                    break;
                case "√x":
                    break;

            }
        }

        private void changePositiveNegative()
        {

        }

        private void addToDisplay(string number)
        {
            if (Display.Text.Equals("0") || Display.Text.Equals("-0"))
            {
                Display.Text = formatNumber(number);
            }
            else
            {
                string currentText = Display.Text.Replace(",", ""); // Quitar comas de separación
                currentText += number;
                Display.Text = formatNumber(currentText);
            } 
        }

        private void deleteFromDisplay() 
        {
            if (!Display.Text.Equals("0") && Display.Text.Length > 0)
            {
                string display = Display.Text;
                display = display.Replace(",", "");
                display = display.Remove(display.Length - 1);

                if (display.Length == 0)
                {
                    Display.Text = "0";
                }
                else
                {
                    Display.Text = formatNumber(display);
                }
            }
        }

        private double calculate(double number, string operatorStr, double number2)
        {
            double resultado = 0;
            switch (operatorStr)
            {
                case "+":
                    resultado = number + number2;
                    break;

                case "-":
                    resultado = number - number2;
                    break;

                case "X":
                    resultado = number * number2;
                    break;

                case "÷":
                    if (number2 != 0)
                    {
                        resultado = number / number2;
                    } else
                    {
                        resultado = double.NaN;
                    } 
                    break;

                case "x²":
                    resultado = Math.Pow(number, number2);
                    break;
            }
            return resultado;
        }

        private double calculate(int number, string operatorStr)
        {
            double resultado = 0;
            if (operatorStr.Equals("√x"))
            {
                resultado = Math.Sqrt(number);
            }
            return resultado;
        }

        private string formatNumber(string number)
        {
            if (double.TryParse(number, out double numericValue))
            {
                return string.Format("{0:#,##0.##}", numericValue);
            }
            return number;
        }

    }
}