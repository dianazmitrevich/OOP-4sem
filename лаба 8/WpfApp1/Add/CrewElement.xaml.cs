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
    /// Логика взаимодействия для CrewElement.xaml
    /// </summary>
    public partial class CrewElement : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-G5D9MGO;Initial Catalog=Airport;Integrated Security=True;MultipleActiveResultSets=True;";

        public CrewElement()
        {
            InitializeComponent();
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
    }
}
