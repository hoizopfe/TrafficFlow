using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFlow.Model
{
    public class SettingsModel : INotifyPropertyChanged /*, IPEndPoint */
        //https://learn.microsoft.com/de-de/dotnet/api/system.net.ipendpoint.-ctor?view=net-7.0
    {
        private IPAddress destinationIPAddress { get; set; }
        private string protocol { get; set; }
        private int portNumber { get; set; }



        public IPAddress DestinationIPAddress
        {
            get => destinationIPAddress;
            set
            {
                destinationIPAddress = value;
                OnPropertyChanged();
            }
        }

        public string Protocol
        {
            get => protocol;
            set
            {
                protocol = value;
                OnPropertyChanged();
            }
        }

        public int PortNumber
        {
            get => portNumber;
            set
            {
                portNumber = value;
                OnPropertyChanged();
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
