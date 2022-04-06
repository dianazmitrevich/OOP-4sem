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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddElement_Click(object sender, RoutedEventArgs e)
        {
            MainField.Children.Clear();
            MainField.Children.Add(new Add());
        }

        private void EditElement_Click(object sender, RoutedEventArgs e)
        {
            MainField.Children.Clear();
            MainField.Children.Add(new Edit());
        }

        private void DeleteElement_Click(object sender, RoutedEventArgs e)
        {
            MainField.Children.Clear();
            MainField.Children.Add(new Delete());
        }
    }
}
