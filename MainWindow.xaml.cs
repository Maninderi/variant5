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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            miCalc_Click(sender, e);
        }

        private void num1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void miCalc_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);
            int c = Convert.ToInt32(num3.Text);

            if (c1.IsChecked == true)
            {
                int OutPut = a + b + c;
                MessageBox.Show($"Результат:  {Convert.ToInt32(OutPut)}", "Ответ", MessageBoxButton.OK);
            } else if (c2.IsChecked == true)
            {
                ;
                
            }
            else if(c1.IsChecked == false && c2.IsChecked == false)
            {
                MessageBox.Show("Нужно нажать на один из вариантов решения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            } else if(c1.IsChecked == true && c2.IsChecked == true)
            {
                int OutPut = a + b + c;
                MessageBox.Show($"Сумма:  {Convert.ToInt32(OutPut)}\n Наименьшее кратное: ...", "Ответ", MessageBoxButton.OK);
            }
        }
        
        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
