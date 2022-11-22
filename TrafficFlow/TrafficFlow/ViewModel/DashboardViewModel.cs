using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrafficFlow.Model;

namespace TrafficFlow.ViewModel
{
    public class DashboardViewModel : BaseViewModel
    {

        public DashboardModel ModelDashboard { get; set; } = new DashboardModel();

        public ICommand StartStoppCommand
        {
            get;
            set;
        }

        public DashboardViewModel()
        {
            StartStoppCommand = new RelayCommand(e => { ModelDashboard.StartStoppTransmission(); }, c => true);
        }
    }
}
