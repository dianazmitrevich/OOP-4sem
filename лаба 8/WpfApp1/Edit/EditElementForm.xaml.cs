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
using System.Windows.Shapes;

namespace WpfApp1.Edit
{
    /// <summary>
    /// Логика взаимодействия для EditElementForm.xaml
    /// </summary>
    public partial class EditElementForm : Window
    {
        public EditElementForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow element = new MainWindow();
            element.Show();
            this.Close();
        }

        private void EditPlane_Click(object sender, RoutedEventArgs e)
        {
            EditElementField.Children.Clear();
            EditElementField.Children.Add(new EditPlane());
        }

        private void EditCrew_Click(object sender, RoutedEventArgs e)
        {
            EditElementField.Children.Clear();
            EditElementField.Children.Add(new EditCrew());
        }

        private void EditManufacturer_Click(object sender, RoutedEventArgs e)
        {
            EditElementField.Children.Clear();
            EditElementField.Children.Add(new EditManufacturer());
        }
    }
}
