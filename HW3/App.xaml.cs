using HW3.Step;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HW3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void AppOnStartup(object sender, StartupEventArgs e)
        {
            this.Step();
        }

        private void Step()
        {
            var viewFactory = new ViewFactory();
            var infrastracture = viewFactory.Create();
            infrastracture.View.DataContext = infrastracture.ViewModel;
            infrastracture.View.Show();
        }
    }
}
