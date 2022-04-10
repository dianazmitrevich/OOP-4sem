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

namespace WpfApp1.Add
{
    /// <summary>
    /// Логика взаимодействия для AddElementForm.xaml
    /// </summary>
    public partial class AddElementForm : Window
    {
        public AddElementForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow element = new MainWindow();
            element.Show();
            this.Close();
        }

        private void AddPlane_Click(object sender, RoutedEventArgs e)
        {
            AddElementField.Children.Clear();
            AddElementField.Children.Add(new PlaneElement());
        }

        private void AddCrew_Click(object sender, RoutedEventArgs e)
        {
            AddElementField.Children.Clear();
            AddElementField.Children.Add(new CrewElement());
        }

        private void AddManufacturer_Click(object sender, RoutedEventArgs e)
        {
            AddElementField.Children.Clear();
            AddElementField.Children.Add(new ManufacturerElement());
        }
    }
}
