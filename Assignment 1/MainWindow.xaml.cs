using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Joshua Saetern
    /// 04.13.2024
    /// Programming 122
    /// Assignment 1 - Basic Calculator
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {   
            //Attempt to parse and perform addition
            try
            {
                double result = double.Parse(txtBoxNum1.Text) + double.Parse(txtBoxNum2.Text);
                MessageBox.Show($"{txtBoxNum1.Text} + {txtBoxNum2.Text} = {result}");
            }
            //Runs if numbers fail to parse
            catch 
            {
                MessageBox.Show("Enter Valid Numbers");
            }
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            //Attempt to parse and perform subtraction
            try
            {
                double result = double.Parse(txtBoxNum1.Text) - double.Parse(txtBoxNum2.Text);
                MessageBox.Show($"{txtBoxNum1.Text} - {txtBoxNum2.Text} = {result}");
            }
            //Runs if numbers fail to parse
            catch
            {
                MessageBox.Show("Enter Valid Numbers");
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            //Attempt to parse and perform multiplication
            try
            {
                double result = double.Parse(txtBoxNum1.Text) * double.Parse(txtBoxNum2.Text);
                MessageBox.Show($"{txtBoxNum1.Text} X {txtBoxNum2.Text} = {result}");
            }
            //Runs if numbers fail to parse
            catch
            {
                MessageBox.Show("Enter Valid Numbers");
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            //Attempt to parse and perform division
            try
            {
                double result = double.Parse(txtBoxNum1.Text) / double.Parse(txtBoxNum2.Text);
                MessageBox.Show($"{txtBoxNum1.Text} \u00F7 {txtBoxNum2.Text} = {result}");
            }
            //Runs if division by zero occurs
            catch (DivideByZeroException)
            {
                MessageBox.Show("DivideByZeroException");
            }
            //Runs if numbers fail to parse
            catch
            {
                MessageBox.Show("Enter Valid Numbers");
            }
        }

    }
}