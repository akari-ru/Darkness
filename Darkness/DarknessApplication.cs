using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using Darkness.UI.ViewModel;

namespace Darkness
{
    public partial class DarknessApplication
    {
        private static DarknessApplication _app;  
        public static DarknessApplication App
        {
            get => _app;
            set
            {
                if ( _app != null )
                {
                    throw new Exception("Only one App instance allowed.");
                }
                else
                {
                    _app = value;
                }
            }
        }
    }

    public partial class DarknessApplication
    {
        #region Bindable Properties
        UserControl _mainContent = null;
        public UserControl MainContent => _mainContent;

        Window _mainWindow;
        public Window MainWindow => _mainWindow;

        Func<UserControl> _fetchMainContent;

        // SessionViewModel - Draft.. later only create on demand ..
        private SessionViewModel _sessionViewModel = new SessionViewModel(Darkness.Model.Session.Instance);
        public SessionViewModel SessionViewModel => _sessionViewModel;
        #endregion

        #region Constructors
        private DarknessApplication() { }
        
        // lazy loading
        public DarknessApplication(Func<UserControl> fetchMainContent)
        {
            DarknessApplication.App = this;
            _fetchMainContent = fetchMainContent;
        }

        // pre fetch
        public DarknessApplication(UserControl mainContent)
        {
            // Guards
            if (mainContent == null) throw new ArgumentNullException(mainContent.ToString() + "was null.");

            // TODO: complete guards

            DarknessApplication.App = this;
            _mainContent = mainContent;
        }
        #endregion

        #region App Events
        public void Application_Startup(object sender, StartupEventArgs e)
        {
            _mainWindow = new MainWindow();
            _mainContent = _mainContent ?? (_fetchMainContent() ?? throw new Exception("No valid MainContent provided"));
            _mainWindow.DataContext = this;
            _mainWindow.Show();
        }

        public void Application_Exit(object sender, ExitEventArgs e)
        {

        }
        #endregion
    }
}
