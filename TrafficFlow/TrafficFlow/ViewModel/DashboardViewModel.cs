using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using TrafficFlow.Model;
using TrafficFlow.TcpModel;

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

            StartStoppCommand = new RelayCommand(async e => 
            {
                TcpServerModel server = new TcpServerModel();
                Thread serverThread = new Thread(server.RunServer);
                serverThread.Start();

                TcpClientModel.Connect("10.20.129.247", "Halllooooo");

                ModelDashboard.StartStoppTransmission(); 

            }, c => true);
        }
    }
}
