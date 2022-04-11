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
    /// Логика взаимодействия для ManufacturerElement.xaml
    /// </summary>
    public partial class ManufacturerElement : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-G5D9MGO;Initial Catalog=Airport;Integrated Security=True;MultipleActiveResultSets=True;";

        public ManufacturerElement()
        {
            InitializeComponent();
        }

        private void AddManufacturerButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridManufacturer.Items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;

                    command.CommandText = "INSERT INTO MANUFACTURER (ID, Name, Country, Year) VALUES (" + Convert.ToInt32(manufacturerID.Text) + ", '" + Convert.ToString(manufacturerName.Text) + "', '" + Convert.ToString(manufacturerCountry.Text) + "', " + Convert.ToInt32(manufacturerYear.Text) + ")";
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
