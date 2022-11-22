using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrafficFlow.Model;

namespace TrafficFlow.ViewModel
{
    public class BaseViewModel
    {
        public ScreenNavigationModel ScreenNaviation { get; set; } = new ScreenNavigationModel();

        public ICommand ChangeScreenSettingsCommand
        {
            get;
            set;
        }
        public ICommand ChangeScreenDashboardCommand
        {
            get;
            set;
        }
        public ICommand ChangeScreenDetailsCommand
        {
            get;
            set;
        }

        public BaseViewModel()
        {
            ChangeScreenSettingsCommand = new RelayCommand(e => { ScreenNaviation.ChangeScreenSettings(); }, c => true);
            ChangeScreenDashboardCommand = new RelayCommand(e => { ScreenNaviation.ChangeScreenDashboard(); }, c => true);
            ChangeScreenDetailsCommand = new RelayCommand(e => { ScreenNaviation.ChangeScreenDetails(); }, c => true);
        }
    }
}
