using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ConsultationViewModel> ConsultationList { get; set; }

        public MainViewModel(List<Consultation> consultations)
        {
            ConsultationList = new ObservableCollection<ConsultationViewModel>(consultations.Select(b => new ConsultationViewModel(b)));
        }
    }
}
