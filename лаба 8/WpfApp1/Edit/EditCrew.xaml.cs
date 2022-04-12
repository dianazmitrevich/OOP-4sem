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
    /// Логика взаимодействия для EditCrew.xaml
    /// </summary>
    public partial class EditCrew : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-G5D9MGO;Initial Catalog=Airport;Integrated Security=True;MultipleActiveResultSets=True;";

        public EditCrew()
        {
            InitializeComponent();
        }

        private void ElementToEditButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridEditCrew.Items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    DataGridEditCrew.Items.Clear();
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandText = "";
                    SqlDataReader reader = command.ExecuteReader();

                    command.CommandText = "UPDATE CREW_MEMBERS SET " + Convert.ToInt32(crewElement.Text) + " = " + Convert.ToInt32(crewNew.Text) + " WHERE CREW_MEMBERS.ID = " + Convert.ToInt32(crewID.Text) + "";
                    command.ExecuteReader();
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
                            DataGridEditCrew.Items.Add(crew);
                        }
                    }
                    MessageBox.Show("Данные изменены", "Изменение данных", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show($"Ошибка: {x.Message}", "Сообщение об ошибке", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
