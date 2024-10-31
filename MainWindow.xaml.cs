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

namespace wasd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int FindLCM(int a, int b)
        {
            return (a * b) / FindGCD(a, b);
        }

        private int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void miInput_Click(object sender, RoutedEventArgs e)
        {
            if(wrapPanel.Visibility == Visibility.Hidden)
            {
                wrapPanel.Visibility = Visibility.Visible;
            }
            else
            {
                wrapPanel.Visibility = Visibility.Hidden;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Рыбалка Женя");
        }

        private bool check()
        {
            return int.TryParse(num1.Text, out _) &&
                   int.TryParse(num2.Text, out _) &&
                   int.TryParse(num3.Text, out _);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            miCalc_Click(sender, e);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Button_Result.IsEnabled = check();
            miCalc.IsEnabled = check();
        }

        private void miCalc_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);
            int c = Convert.ToInt32(num3.Text);

            int lcm = FindLCM(a, b);
            int OutPut = a + b + c;


            if (c1.IsChecked == true && c2.IsChecked == false)
            {
                MessageBox.Show($"Сумма:  {Convert.ToInt32(OutPut)}", "Ответ", MessageBoxButton.OK);
            }
            else if (c2.IsChecked == true && c1.IsChecked == false)
            {
                MessageBox.Show($"Наименьшее кратное: {lcm}", "Ответ", MessageBoxButton.OK);
            }
            else if (c1.IsChecked == true && c2.IsChecked == true)
            {
                MessageBox.Show($"Сумма:  {Convert.ToInt32(OutPut)}\nНаименьшее кратное: {lcm}", "Ответ", MessageBoxButton.OK);
            }
            else
                MessageBox.Show("Нужно нажать на один из вариантов решения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); 
        }
        
        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
