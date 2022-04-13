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
using System.Windows.Shapes;

namespace WpfApp1.Remove
{
    /// <summary>
    /// Логика взаимодействия для RemoveElementForm.xaml
    /// </summary>
    public partial class RemoveElementForm : Window
    {
        string connectionString = @"Data Source=DESKTOP-G5D9MGO;Initial Catalog=Airport;Integrated Security=True;MultipleActiveResultSets=True;";

        public RemoveElementForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow element = new MainWindow();
            element.Show();
            this.Close();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string tableName = Convert.ToString(ElementToRemoveBox.Text);
                string idName = Convert.ToString(IDToRemove.Text);
                int planeRowCount = 0, planeRowCountNew = 0;

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                command.CommandText = "SELECT COUNT(*) FROM " + tableName + "";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        planeRowCount = reader.GetInt32(0);
                    }
                reader.Close();

                command.CommandText = "DELETE FROM " + tableName + " WHERE ID=" + idName + "";
                command.ExecuteNonQuery();
                transaction.Commit();
                command.CommandText = "SELECT COUNT(*) FROM " + tableName + "";
                SqlDataReader readerNew = command.ExecuteReader();
                if (readerNew.HasRows)
                    while (readerNew.Read())
                    {
                        planeRowCountNew = readerNew.GetInt32(0);
                    }

                if (planeRowCount == planeRowCountNew)
                    MessageBox.Show("Элемента с таким ID не существует", "Удаление данных", MessageBoxButton.OK, MessageBoxImage.Information);
                else
                    MessageBox.Show("Данные удалены", "Удаление данных", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show($"Ошибка: {x.Message}", "Сообщение об ошибке", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
