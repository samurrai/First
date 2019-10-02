using System;
using System.Collections;
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

namespace First
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> products;   

        public MainWindow()
        {
            InitializeComponent();
            products = new List<string>();
        }


        private void FirstButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(firstTextBox.Text))
            {
                products.Add(firstTextBox.Text);
                firstTextBox.Text = "";
            }
        }

        private void SecondButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(secondTextBox.Text))
            {
                products.Add(secondTextBox.Text);
                secondTextBox.Text = "";
            }
        }

        private void ThirdButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(thirdTextBox.Text))
            {
                products.Add(thirdTextBox.Text);
                thirdTextBox.Text = "";
            }
        }

        private void FourthButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fourthTextBox.Text))
            {
                products.Add(fourthTextBox.Text);
                fourthTextBox.Text = "";
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string productsString = "";
            foreach (var product in products)
            {
                productsString += product + ", ";
            }
            MessageBox.Show(productsString);
        }
    }
}
