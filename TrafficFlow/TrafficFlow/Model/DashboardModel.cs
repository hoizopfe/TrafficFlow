using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace TrafficFlow.Model
{
    public class DashboardModel : BaseModel
    {
        private int progressBarValue = 0;

        public int ProgressBarValue
        {
            get { return progressBarValue; }
            set
            {
                progressBarValue = value;
                OnPropertyChanged("ProgressBarValue");
            }
        }

        public void StartStoppTransmission()
        {
            Thread startProgressBarThread = new Thread(new ThreadStart(StartProgressBar));
            startProgressBarThread.Start();
        }

        private void StartProgressBar()
        {
            for (int index = 0; index <= 100; index++)
            {
                Application.Current.Dispatcher.Invoke(() =>                 
                {
                    ProgressBarValue++;
                });
                Thread.Sleep(30);
            }
        }
    }
}
