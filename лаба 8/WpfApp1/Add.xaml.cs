using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
        }

        private void ElementToAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (ElementToAddBox.Text == "Самолет")
            {
                AddElementField.Children.Clear();
                AddElementField.Children.Add(new AddPlane());
            }
            else if (ElementToAddBox.Text == "Работник")
            {
                AddElementField.Children.Clear();
                AddElementField.Children.Add(new AddCrewMember());
            }
            else if (ElementToAddBox.Text == "Производитель")
            {
                AddElementField.Children.Clear();
                AddElementField.Children.Add(new AddManufacturer());
            }
        }
    }
}