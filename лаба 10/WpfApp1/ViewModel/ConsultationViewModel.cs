using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class ConsultationViewModel : ViewModelBase
    {
        public Consultation Consultation;
        //public string enrollmentLabel = "Вы не записаны";

        public ConsultationViewModel(Consultation consultation)
        {
            this.Consultation = consultation;
        }

        public string FIO
        {
            get { return Consultation.FIO; }
            set
            {
                Consultation.FIO = value;
                OnPropertyChanged("FIO");
            }
        }
        public string Discipline
        {
            get { return Consultation.Discipline; }
            set
            {
                Consultation.Discipline = value;
                OnPropertyChanged("Discipline");
            }
        }
        public string Date
        {
            get { return Consultation.Date; }
            set
            {
                Consultation.Date = value;
                OnPropertyChanged("Date");
            }
        }
        public string Duration
        {
            get { return Consultation.Duration; }
            set
            {
                Consultation.Duration = value;
                OnPropertyChanged("Duration");
            }
        }
        public string Enrollment
        {
            get { return Consultation.Enrollment; }
            set
            {
                Consultation.Enrollment = value;
                OnPropertyChanged("Enrollment");
            }
        }

        private DelegateCommand enrollCommand;
        public ICommand EnrollCommand
        {
            get
            {
                if (enrollCommand == null)
                {
                    enrollCommand = new DelegateCommand(Enroll, CanEnroll);
                }
                return enrollCommand;
            }
        }

        private void Enroll()
        {
            Enrollment = "Вы записаны";
        }

        private bool CanEnroll()
        {
            return !(Enrollment == "Вы записаны");
        }

        private DelegateCommand enrolCommand;
        public ICommand EnrolCommand
        {
            get
            {
                if (enrolCommand == null)
                {
                    enrolCommand = new DelegateCommand(Enrol, CanEnrol);
                }
                return enrolCommand;
            }
        }

        private void Enrol()
        {
            Enrollment = "Вы не записаны";
        }

        private bool CanEnrol()
        {
            return !(Enrollment == "Вы не записаны");
        }
    }
}