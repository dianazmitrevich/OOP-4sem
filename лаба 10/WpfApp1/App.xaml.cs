using System.Collections.Generic;
using System.Windows;
using WpfApp1.Model;
using WpfApp1.View;
using System.Linq;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<Consultation> consultation = new List<Consultation>();
        private void OnStartup(object sender, StartupEventArgs e)
        {
            ConsultationEntities db = new ConsultationEntities();
            var consultations = from d in db.Consultations
                                select d;

            foreach (var item in consultations)
            {
                Consultation element = new Consultation()
                {
                    FIO = item.FIO,
                    Discipline = item.Discipline,
                    Date = item.Date,
                    Duration = item.Duration
                };
                consultation.Add(item);
            }

            MainWindow view = new MainWindow(); // создали View
            MainViewModel viewModel = new MainViewModel(consultation); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }
    }
}