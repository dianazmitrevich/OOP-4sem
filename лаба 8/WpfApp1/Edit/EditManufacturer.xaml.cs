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
    /// Логика взаимодействия для EditManufacturer.xaml
    /// </summary>
    public partial class EditManufacturer : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-G5D9MGO;Initial Catalog=Airport;Integrated Security=True;MultipleActiveResultSets=True;";

        public EditManufacturer()
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = "SELECT * FROM MANUFACTURER";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string country = reader.GetString(2);
                    int year = reader.GetInt32(3);
                    Manufacturer manufacturer = new Manufacturer(id, name, country, year);
                    DataGridManufacturer.Items.Add(manufacturer);
                }
            }
        }

        private void ElementToEditButton_Click(object sender, RoutedEventArgs e)
        {
            int manufacturerName = Convert.ToInt32(manufacturerID.Text);
            string parameter = Convert.ToString(manufacturerParameter.Text);
            string newValue = Convert.ToString(manufacturerNewParameter.Text);

            DataGridManufacturer.Items.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = "UPDATE MANUFACTURER SET MANUFACTURER." + parameter + "='" + newValue + "' WHERE MANUFACTURER.ID=" + manufacturerName + "";
            command.ExecuteNonQuery();
            transaction.Commit();
            command.CommandText = "SELECT * FROM MANUFACTURER";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string country = reader.GetString(2);
                    int year = reader.GetInt32(3);
                    Manufacturer manufacturer = new Manufacturer(id, name, country, year);
                    DataGridManufacturer.Items.Add(manufacturer);
                }
            }
            MessageBox.Show("Данные изменены", "Редактирование данных", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
