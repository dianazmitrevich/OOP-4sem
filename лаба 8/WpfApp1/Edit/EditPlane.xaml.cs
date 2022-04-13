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

namespace WpfApp1.Edit
{
    /// <summary>
    /// Логика взаимодействия для EditPlane.xaml
    /// </summary>
    public partial class EditPlane : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-G5D9MGO;Initial Catalog=Airport;Integrated Security=True;MultipleActiveResultSets=True;";

        public EditPlane()
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

        private void ElementToEditButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int planeName = Convert.ToInt32(planeID.Text);
                string parameter = Convert.ToString(planeParameter.Text);
                string newValue = Convert.ToString(planeNewParameter.Text);

                DataGridPlanes.Items.Clear();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                if (planeParameter.Text == "Type" || planeParameter.Text == "Model" || planeParameter.Text == "Load_Capacity")
                    command.CommandText = "UPDATE PLANE SET PLANE." + parameter + "='" + newValue + "' WHERE PLANE.ID=" + planeName + "";
                else if (planeParameter.Text == "Capacity" || planeParameter.Text == "Year" || planeParameter.Text == "Manufacturer_ID")
                    command.CommandText = "UPDATE PLANE SET PLANE." + parameter + "=" + newValue + " WHERE PLANE.ID=" + planeName + "";
                else
                    MessageBox.Show("Выберите хоть один параметр для изменения");

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
                MessageBox.Show("Данные изменены", "Редактирование данных", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show($"Ошибка: {x.Message}", "Сообщение об ошибке", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
