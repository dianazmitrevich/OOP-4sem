using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
    /// Логика взаимодействия для AddPlane.xaml
    /// </summary>
    public partial class AddPlane : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Airport.mdf;Integrated Security=True";
        string radioButtonModel;

        public AddPlane()
        {
            InitializeComponent();
        }

        private void AddPlaneButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;

                    command.CommandText = "INSERT INTO PLANE (ID, PlaneType, Model, Capacity, PlaneYear, LoadCapacity, Maintenance, ManufacturerID) VALUES (" + Convert.ToInt32(planeID.Text) + ", '" + Convert.ToString(planeType.Text) + "', '" + radioButtonModel + "', " + Convert.ToInt32(planeCapacity.Text) + ", " + Convert.ToInt32(planeYear.Text) + ", '" + planeLoadCapacity.Text + "', '" + planeMDate.Text + "', NULL)";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Данные добавлены", "Добавление данных", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show($"Ошибка: {x.Message}", "Сообщение об ошибке", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void rbAirbus_Checked(object sender, RoutedEventArgs e)
        {
            radioButtonModel = Convert.ToString(rbAirbus.Content);
        }
        private void rbBoeing_Checked(object sender, RoutedEventArgs e)
        { 
            radioButtonModel = Convert.ToString(rbBoeing.Content);
        }
    }
}
