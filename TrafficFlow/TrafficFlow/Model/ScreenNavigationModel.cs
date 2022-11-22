using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TrafficFlow.View;

namespace TrafficFlow.Model
{
    public class ScreenNavigationModel
    {

        public void ChangeScreenSettings()
        {
            ChangeScreen(new Settings());
        }

        public void ChangeScreenDashboard()
        {
            ChangeScreen(new Dashboard());
        }

        public void ChangeScreenDetails()
        {
            ChangeScreen(new Details());
        }

        public void ChangeScreen(Window wnd)
        {
            wnd.Top = App.Current.MainWindow.Top;
            wnd.Left = App.Current.MainWindow.Left;
            wnd.Show();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = wnd;
        }
    }
}
