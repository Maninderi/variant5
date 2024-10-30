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

        }
    }
}
