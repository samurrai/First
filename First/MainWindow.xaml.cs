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
    public partial class MainWindow : Window // наше окно
    {
        List<string> products;   // список товаров

        public MainWindow()
        {
            InitializeComponent(); // инициализация компонентов в окне
            products = new List<string>();
        }


        private void FirstButtonClick(object sender, RoutedEventArgs e) // кнопка добавления первого товара
        {
            if (!string.IsNullOrWhiteSpace(firstTextBox.Text)) // если название не пустое, то добавить товар
            {
                products.Add(firstTextBox.Text);
                firstTextBox.Text = ""; // очистка текстового поля
            }
        }

        private void SecondButtonClick(object sender, RoutedEventArgs e) // кнопка добавления второго товара
        {
            if (!string.IsNullOrWhiteSpace(secondTextBox.Text)) // если название не пустое, то добавить товар
            {
                products.Add(secondTextBox.Text);
                secondTextBox.Text = ""; // очистка текстового поля
            }
        }

        private void ThirdButtonClick(object sender, RoutedEventArgs e) // кнопка добавления третьего товара
        {
            if (!string.IsNullOrWhiteSpace(thirdTextBox.Text)) // если название не пустое, то добавить товар
            {
                products.Add(thirdTextBox.Text);
                thirdTextBox.Text = ""; // очистка текстового поля
            }
        }

        private void FourthButtonClick(object sender, RoutedEventArgs e) // кнопка добавления четвертого товара
        {
            if (!string.IsNullOrWhiteSpace(fourthTextBox.Text)) // если название не пустое, то добавить товар
            {
                products.Add(fourthTextBox.Text);
                fourthTextBox.Text = ""; // очистка текстового поля
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e) // кнопка просмотра корзины
        {
            string productsString = ""; // строка продуктов
            foreach (var product in products)
            {
                productsString += product + ", "; // из списка продуктов добавляем продукт в строку продуктов через запятую
            }
            MessageBox.Show(productsString); // показать список продуктов
        }
    }
}
