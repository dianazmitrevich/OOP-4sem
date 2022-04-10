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

namespace WpfApp1.Remove
{
    /// <summary>
    /// Логика взаимодействия для RemoveElementForm.xaml
    /// </summary>
    public partial class RemoveElementForm : Window
    {
        public RemoveElementForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow element = new MainWindow();
            element.Show();
            this.Close();
        }
    }
}
