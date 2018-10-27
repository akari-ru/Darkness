using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using Darkness;


namespace Fork
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        DarknessApplication _darknessApplication;

        public App()
        {
            _darknessApplication = new DarknessApplication(() => new Fork.UI.View.MainContent());
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _darknessApplication.Application_Startup(sender, e);
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            _darknessApplication.Application_Exit(sender, e);
        }

    }
}
