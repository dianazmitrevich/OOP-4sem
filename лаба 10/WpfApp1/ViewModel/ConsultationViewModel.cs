using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class ConsultationViewModel : ViewModelBase
    {
        public Consultation Consultation;

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
    }
}
