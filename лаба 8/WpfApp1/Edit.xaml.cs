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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : UserControl
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void ElementToEditButton_Click(object sender, RoutedEventArgs e)
        {
            if (ElementToEditBox.Text == "Самолет")
            {
                EditElementField.Children.Clear();
                EditElementField.Children.Add(new EditPlane());
            }
            else if (ElementToEditBox.Text == "Работник")
            {
                EditElementField.Children.Clear();
                EditElementField.Children.Add(new AddCrewMember());
            }
            else if (ElementToEditBox.Text == "Производитель")
            {
                EditElementField.Children.Clear();
                EditElementField.Children.Add(new EditManufacturer());
            }
        }
    }
}
