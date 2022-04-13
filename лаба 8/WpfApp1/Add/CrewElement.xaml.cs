using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для CrewElement.xaml
    /// </summary>
    public partial class CrewElement : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-G5D9MGO;Initial Catalog=Airport;Integrated Security=True;MultipleActiveResultSets=True;";

        public CrewElement()
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = "SELECT * FROM CREW_MEMBERS";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nameSurname = reader.GetString(1);
                    string position = reader.GetString(2);
                    int age = reader.GetInt32(3);
                    int experience = reader.GetInt32(4);
                    int planeID = reader.GetInt32(5);
                    CrewMember crew = new CrewMember(id, nameSurname, position, age, experience, planeID);
                    DataGridCrew.Items.Add(crew);
                }
            }
        }

        private void AddCrewMemberButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridCrew.Items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;

                    command.CommandText = "INSERT INTO CREW_MEMBERS (ID, Name_Surname, Position, Age, Experience, Plane_ID) VALUES (" + Convert.ToInt32(crewID.Text) + ", '" + Convert.ToString(crewFIO.Text) + "', '" + Convert.ToString(crewPosition.Text) + "', " + Convert.ToInt32(crewBirthYear.Text) + ", " + Convert.ToInt32(crewExperience.Text) + ", " + Convert.ToInt32(crewPlaneID.Text) + ")";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    command.CommandText = "SELECT * FROM CREW_MEMBERS";
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nameSurname = reader.GetString(1);
                            string position = reader.GetString(2);
                            int age = reader.GetInt32(3);
                            int experience = reader.GetInt32(4);
                            int planeID = reader.GetInt32(5);
                            CrewMember crew = new CrewMember(id, nameSurname, position, age, experience, planeID);
                            DataGridCrew.Items.Add(crew);
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

        private void crewID_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(crewID.Text, @"\D") || crewID.Text == "")
                crewID.BorderBrush = Brushes.Red;
            else
                crewID.BorderBrush = Brushes.LimeGreen;
        }

        private void crewPlaneID_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(crewPlaneID.Text, @"\D") || crewPlaneID.Text == "")
                crewPlaneID.BorderBrush = Brushes.Red;
            else
                crewPlaneID.BorderBrush = Brushes.LimeGreen;
        }

        private void crewFIO_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(crewFIO.Text, @"\d") || crewFIO.Text == "")
                crewFIO.BorderBrush = Brushes.Red;
            else
                crewFIO.BorderBrush = Brushes.LimeGreen;
        }

        private void crewBirthYear_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(crewBirthYear.Text, @"\D") || crewBirthYear.Text == "" || crewBirthYear.Text.Length > 4)
                crewBirthYear.BorderBrush = Brushes.Red;
            else
                crewBirthYear.BorderBrush = Brushes.LimeGreen;
        }

        private void crewExperience_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(crewExperience.Text, @"\D") || crewExperience.Text == "" || crewExperience.Text.Length > 2)
                crewExperience.BorderBrush = Brushes.Red;
            else
                crewExperience.BorderBrush = Brushes.LimeGreen;
        }
    }
}
