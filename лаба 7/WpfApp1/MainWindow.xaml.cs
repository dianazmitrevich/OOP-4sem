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
        public static Color colorCoordinate;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SwatchesStack.Children.Count == 5)
            {
                SwatchesStack.Children.RemoveAt(0);
                SwatchesStack.Children.Add(new ColorSwatch(colorCoordinate));
            }
            else
                SwatchesStack.Children.Add(new ColorSwatch(colorCoordinate));
        }

        public void SetBackgroundColor(Color colorCoordinate)
        {
            WindowLaba.Background = new SolidColorBrush(colorCoordinate);
        }

        private void CustomCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("RoutedUICommand!");
        }
    }
}
