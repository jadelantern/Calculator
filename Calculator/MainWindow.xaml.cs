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
        MathCalculator mathCalc = new MathCalculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberBTN_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (DisplayTB.Text == "")
            {
                DisplayTB.Text = clickedButton.Content.ToString();
            }
            else if (DisplayTB.Text != "")
            {
                DisplayTB.Text += clickedButton.Content.ToString();
            }
        }

        private void EqualsBTN_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayTB.Text.Contains("+"))
            {
                var addNumbers = DisplayTB.Text.Split('+');

                int num1 = Convert.ToInt32(addNumbers[0]);
                int num2 = Convert.ToInt32(addNumbers[1]);
                int aswAdd;

                DisplayTB.Text = "";
                aswAdd = mathCalc.Add(num1, num2);
                DisplayTB.Text = aswAdd.ToString();
            }
            else if (DisplayTB.Text.Contains("-"))
            {
                var subNumbers = DisplayTB.Text.Split('-');

                int num1 = Convert.ToInt32(subNumbers[0]);
                int num2 = Convert.ToInt32(subNumbers[1]);
                int aswSub;

                DisplayTB.Text = "";
                aswSub = mathCalc.Subtract(num1, num2);
                DisplayTB.Text = aswSub.ToString();
            }
            else if (DisplayTB.Text.Contains("*"))
            {
                var multNumbers = DisplayTB.Text.Split('*');

                int num1 = Convert.ToInt32(multNumbers[0]);
                int num2 = Convert.ToInt32(multNumbers[1]);
                int aswMult;

                DisplayTB.Text = "";
                aswMult = mathCalc.Multiply(num1, num2);
                DisplayTB.Text = aswMult.ToString();
            }
            else if (DisplayTB.Text.Contains("/"))
            {
                var divNumbers = DisplayTB.Text.Split('/');

                int num1 = Convert.ToInt32(divNumbers[0]);
                int num2 = Convert.ToInt32(divNumbers[1]);
                int aswDiv;

                DisplayTB.Text = "";
                aswDiv = mathCalc.Divide(num1, num2);
                DisplayTB.Text = aswDiv.ToString();
            }
        }
        private void ClearBTN_Click(object sender, RoutedEventArgs e)
        {
            DisplayTB.Text = "";
        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
