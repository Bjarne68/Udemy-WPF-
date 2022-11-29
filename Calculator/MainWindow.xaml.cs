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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        public MainWindow()
        {
            InitializeComponent();
            

            acButton.Click += AcButton_Click;
            negativeButton.Click += NegativeButton_Click;
            procentButton.Click += ProcentButton_Click;
            resultButton.Click += ResultButton_Click;
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ProcentButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100; ;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }

        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void buttonNumber_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if(sender == buttonZero)
            {
                selectedValue = 0;
            }
            else if(sender == buttonOne)
            {
                selectedValue = 1;
            }
            else if (sender == buttonTwo)
            {
                selectedValue = 2;
            }
            else if (sender == buttonThree)
            {
                selectedValue = 3;
            }
            else if (sender == buttonFour)
            {
                selectedValue = 4;
            }
            else if (sender == buttonFive)
            {
                selectedValue = 5;
            }
            else if (sender == buttonSix)
            {
                selectedValue = 6;
            }
            else if (sender == buttonSeven)
            {
                selectedValue = 7;
            }
            else if (sender == buttonEight) 
            {
                selectedValue = 8;
            }
            else if (sender == buttonNine)
            {
                selectedValue = 9;
            }


            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }
    }
}
