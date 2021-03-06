using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = "SELECT PLANE.ID, PLANE.Type, PLANE.Model, PLANE.Capacity, PLANE.Year, PLANE.Load_Capacity, PLANE.Maintenance_Date, MANUFACTURER.Name FROM PLANE INNER JOIN MANUFACTURER ON MANUFACTURER.ID=PLANE.Manufacturer_ID";
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
                    string manufacturer = reader.GetString(7);
                    Plane plane = new Plane(id, type, model, capacity, year, loadCapacity, maintenance, manufacturer);
                    DataGridPlanes.Items.Add(plane);
                }
            }
        }

        private void rbAirbus_Checked(object sender, RoutedEventArgs e) => radioButtonModel = "Airbus";
        private void rbBoeing_Checked(object sender, RoutedEventArgs e) => radioButtonModel = "Boeing";

        private void AddPlaneButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    DataGridPlanes.Items.Clear();
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;

                    command.CommandText = "INSERT INTO PLANE (ID, Type, Model, Capacity, Year, Load_Capacity, Maintenance_Date, Manufacturer_ID) VALUES (" + Convert.ToInt32(planeID.Text) + ", '" + Convert.ToString(planeType.Text) + "', '" + radioButtonModel + "', " + Convert.ToInt32(planeCapacity.Text) + ", " + Convert.ToInt32(planeYear.Text) + ", '" + planeLoadCapacity.Text + "', '" + Convert.ToDateTime(planeMDate.Text) + "', " + Convert.ToInt32(planeManufacturer.Text) + ")";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    command.CommandText = "SELECT PLANE.ID, PLANE.Type, PLANE.Model, PLANE.Capacity, PLANE.Year, PLANE.Load_Capacity, PLANE.Maintenance_Date, MANUFACTURER.Name FROM PLANE INNER JOIN MANUFACTURER ON MANUFACTURER.ID=PLANE.Manufacturer_ID";
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
                            string manufacturer = reader.GetString(7);
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

        private void planeID_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(planeID.Text, @"\D") || planeID.Text == "")
                planeID.BorderBrush = Brushes.Red;
            else
                planeID.BorderBrush = Brushes.LimeGreen;
        }

        private void planeCapacity_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(planeCapacity.Text, @"\D") || planeCapacity.Text == "")
                planeCapacity.BorderBrush = Brushes.Red;
            else
                planeCapacity.BorderBrush = Brushes.LimeGreen;
        }

        private void planeYear_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(planeYear.Text, @"\D") || planeYear.Text == "" || planeYear.Text.Length != 4)
                planeYear.BorderBrush = Brushes.Red;
            else
                planeYear.BorderBrush = Brushes.LimeGreen;
        }

        private void planeLoadCapacity_LostFocus(object sender, RoutedEventArgs e)
        {
            if (planeLoadCapacity.Text == "")
                planeLoadCapacity.BorderBrush = Brushes.Red;
            else
                planeLoadCapacity.BorderBrush = Brushes.LimeGreen;
        }

        private void planeManufacturer_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(planeManufacturer.Text, @"\D") || planeManufacturer.Text == "")
                planeManufacturer.BorderBrush = Brushes.Red;
            else
                planeManufacturer.BorderBrush = Brushes.LimeGreen;
        }
    }
}
