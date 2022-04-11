using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WpfApp1.Add
{
    /// <summary>
    /// Логика взаимодействия для PlaneElement.xaml
    /// </summary>
    public partial class PlaneElement : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-G5D9MGO;Initial Catalog=Airport;Integrated Security=True;MultipleActiveResultSets=True;";
        string radioButtonModel;

        public PlaneElement()
        {
            InitializeComponent();
        }

        private void rbAirbus_Checked(object sender, RoutedEventArgs e) => radioButtonModel = "Airbus";
        private void rbBoeing_Checked(object sender, RoutedEventArgs e) => radioButtonModel = "Boeing";

        private void AddPlaneButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridPlanes.Items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;

                    command.CommandText = "INSERT INTO PLANE (ID, Type, Model, Capacity, Year, Load_Capacity, Maintenance_Date, Manufacturer_ID) VALUES (" + Convert.ToInt32(planeID.Text) + ", '" + Convert.ToString(planeType.Text) + "', '" + radioButtonModel + "', " + Convert.ToInt32(planeCapacity.Text) + ", " + Convert.ToInt32(planeYear.Text) + ", '" + planeLoadCapacity.Text + "', '" + Convert.ToDateTime(planeMDate.Text) + "', " + Convert.ToInt32(planeManufacturer.Text) + ")";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    command.CommandText = "SELECT * FROM PLANE";
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string type = reader.GetString(1);
                            string model = reader.GetString(2);
                            int capacity = reader.GetInt32(3);
                            int year = reader.GetInt32(4);
                            string loadCapacity = reader.GetString(5);
                            DateTime maintenance = reader.GetDateTime(6);
                            int manufacturer = reader.GetInt32(7);
                            Plane plane = new Plane(id, type, model, capacity, year, loadCapacity, maintenance, manufacturer);
                            DataGridPlanes.Items.Add(plane);
                        }
                    }
                    MessageBox.Show("Данные добавлены", "Добавление данных", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show($"Ошибка: {x.Message}", "Сообщение об ошибке", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
